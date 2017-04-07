using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jehlounCompany
{
    public partial class jehlounCompany : Form
    {

        public int selectig_from_to = 0;
        private bool _valid = false;

        public string trida { get; set; }
        private int dospeli { get; set; }
        private int deti { get; set; }
        private int seniori { get; set; }
        public List<Osoba> osoby = new List<Osoba>();
        

        public jehlounCompany()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void jehlounCompany_Load(object sender, EventArgs e)
        {

            Datab.Instance.Configure(@"|DataDirectory|\databaze\letenkovac.sqlite");

            List<Row> reader = Datab.Instance.SelectQuery("select * from tbDestinace order by jmeno asc");
            foreach (Row row in reader)
            {
                cbOdkud.Items.Add(row.hodnoty[1]);
                cbKam.Items.Add(row.hodnoty[1]);
            }
            
        }

        //otevře okno s počtem cestujících
        private void buttTridaCestujici_Click(object sender, EventArgs e)
        {
            Cestujicii fCes = new Cestujicii(this);
            fCes.Show();
        }

        //vytvoření osob
        public void vytvorCestujici (int _dospeli, int _deti, int _seniori)
        {
            

            for (int i = 0; i < (_dospeli); i++)
            {
                Osoba os = new Osoba();
                os.urciTyp("dospelak");
                osoby.Add(os);
            }

            for (int i = 0; i < (_seniori); i++)
            {
                Osoba os = new Osoba();
                os.urciTyp("senior");
                osoby.Add(os);
            }

            for (int i = 0; i < (_deti); i++)
            {
                Osoba os = new Osoba();
                os.urciTyp("dite");
                osoby.Add(os);
            }


        }

        public int ziskejPocetZestujicich(string cestujici)
        {
            int i = 0;
            if (cestujici == "dospelak")
            {
                foreach (var item in osoby)
                {
                    if(item.typ == "dospelak")
                    {
                        i++;
                    }
                }
                return i;
            }

            else if (cestujici == "senior")
            {
                foreach (var item in osoby)
                {
                    if (item.typ == "senior")
                    {
                        i++;
                    }
                }
                return i;
            }

            else
            {
                foreach (var item in osoby)
                {
                    if (item.typ == "dite")
                    {
                        i++;
                    }
                }
                return i;
            }
        }

        public void nastavHodnotuRichBox()
        {
            rtbCestujici.Clear();
            rtbCestujici.AppendText(String.Format("Dospělí: {0}{1}", ziskejPocetZestujicich("dospelak"), Environment.NewLine));
            rtbCestujici.AppendText(String.Format("Senioři: {0}{1}", ziskejPocetZestujicich("senior"), Environment.NewLine));
            rtbCestujici.AppendText(String.Format("Děti: {0}{1}", ziskejPocetZestujicich("dite"), Environment.NewLine));
        }

        //získá sql příkaz
        private string sqlSelect(string odkud, string kam, DateTime denOdletu)
        {
            string sql_query_base = "select l.*, d.jmeno as pocatek, dd.jmeno as konec from tbLet l inner join tbDestinace d on l.start_destinace = d.id inner join tbDestinace dd on l.cilova_destinace = dd.id inner join tbLetadlo Let on l.letadlo = Let.id where";
            string sql_where = " Let.kapacita > " + osoby.Count.ToString() + " AND datum_odletu > '" + Datab.Instance.FormatDateTo(denOdletu) + "' AND d.jmeno LIKE '" + odkud + "%%' AND dd.jmeno LIKE '" + kam + "%%'";
            string sql_order = "ORDER BY datum_odletu ASC";
            string complete_sql = sql_query_base + sql_where + sql_order;
            return complete_sql;
        }

        //získá volné lety z sql příkazu
        private List<Let> ziskejVolneLety(string sqlSelect)
        {
            List<Row> lety_s = Datab.Instance.SelectQuery(sqlSelect);
            List<Let> volneLety = new List<Let>();

            foreach (Row row in lety_s)
            {
                Console.WriteLine(row.hodnoty[4]);
                DateTime parse_date = DateTime.ParseExact(row.hodnoty[4], "yyyy-M-d H:m", CultureInfo.InvariantCulture);
                Let let = new Let(int.Parse(row.hodnoty[0]), int.Parse(row.hodnoty[1]), row.hodnoty[6], int.Parse(row.hodnoty[2]), row.hodnoty[7], int.Parse(row.hodnoty[3]), parse_date, int.Parse(row.hodnoty[5]));
                volneLety.Add(let);
            }
            return volneLety;
        }

        //jednosměrný nebo zpáteční let
        private void buttDalsi_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                if (ziskejPocetZestujicich("dospelak") != 0 || ziskejPocetZestujicich("senior") != 0)
                {
                    if (rbjednosmerny.Checked)
                    {
                        if (ziskejVolneLety(sqlSelect(cbOdkud.Text, cbKam.Text, dtpDenOdletu.Value)).Count != 0)
                        {
                            VyberLetu vyber = new VyberLetu(ziskejVolneLety(sqlSelect(cbOdkud.Text, cbKam.Text, dtpDenOdletu.Value)), this);
                            vyber.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("nemáme pro vás Vámi vybraný let");
                        }


                    }

                    else
                    {
                        if (ziskejVolneLety(sqlSelect(cbOdkud.Text, cbKam.Text, dtpDenOdletu.Value)).Count != 0 && ziskejVolneLety(sqlSelect(cbKam.Text, cbOdkud.Text, dtpDenOdletu.Value)).Count != 0)
                        {
                            VyberLetu vyber = new VyberLetu(ziskejVolneLety(sqlSelect(cbOdkud.Text, cbKam.Text, dtpDenOdletu.Value)), this, ziskejVolneLety(sqlSelect(cbKam.Text, cbOdkud.Text, dtpDenPriletu.Value)));
                            vyber.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("nemáme pro vás Vámi vybraný let");
                        }


                    }
                }

                else
                {
                    MessageBox.Show("nelze objednat, protože jste nevybrali plnoletého cestujícího");
                }
            }

        }



        //prohodí odkud <----> kam
        private void buttProhoditLet_Click(object sender, EventArgs e)
        {
            string temp;
            temp = cbOdkud.Text;
            cbOdkud.Text = cbKam.Text;
            cbKam.Text = temp;

        }

        //nechá zmizet možnost volby pro zpáteční let
        private void rbjednosmerny_CheckedChanged(object sender, EventArgs e)
        {
            if (rbjednosmerny.Checked)
            {
                this.dtpDenPriletu.Visible = false;
                this.lbDenPriletu.Visible = false;
            }
            
            else
            {
                this.dtpDenPriletu.Visible = true;
                this.lbDenPriletu.Visible = true;
            }
        }

        public bool zjistiTypLetu()
        {
            return rbZpatky.Checked;
        }

        private void rbZpatky_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void buttMapa_Click(object sender, EventArgs e)
        {
            Mapa mapa = new Mapa();
            mapa.Show();
        }

        private void buttVynulovatOsoby_Click(object sender, EventArgs e)
        {
            osoby = new List<Osoba>();
            nastavHodnotuRichBox();
        }

        public int ziskejTriduLetu()
        {
            return cbTrida.SelectedIndex;
        }

        private bool IsValid()
        {
            bool valid = true;
            this.errorProvider.Clear();

            // odkud
            if (string.IsNullOrWhiteSpace(this.cbOdkud.Text))
            {
                valid = false;
                this.errorProvider.SetError(this.cbOdkud, "Nesmi byt prazdne");
            }

            // kam
            if (string.IsNullOrWhiteSpace(this.cbKam.Text))
            {
                valid = false;
                this.errorProvider.SetError(this.cbKam, "Nesmi byt prazdne");
            }

            // trida
            if (string.IsNullOrWhiteSpace(this.cbTrida.Text))
            {
                valid = false;
                this.errorProvider.SetError(this.cbTrida, "Nesmi byt prazdne");
            }


            if (zjistiTypLetu())
            {
                /*porovnání datum odletu > datum příletu
                if (string.IsNullOrWhiteSpace(this.tbTelefon.Text))
                {
                    valid = false;
                    this.errorProvider.SetError(this.tbTelefon, "Nesmi byt prazdne");
                }*/

            }

            return valid;
        }

        private void cbOdkud_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.cbOdkud, null);
            if (string.IsNullOrWhiteSpace(this.cbOdkud.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.cbOdkud, "Nesmi byt prazdne");
            }
        }

        private void cbKam_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.cbKam, null);
            if (string.IsNullOrWhiteSpace(this.cbKam.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.cbKam, "Nesmi byt prazdne");
            }
        }

        private void cbTrida_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.cbTrida, null);
            if (string.IsNullOrWhiteSpace(this.cbTrida.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.cbTrida, "Nesmi byt prazdne");
            }
        }

        private void dtpDenPriletu_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
