using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jehlounCompany
{
    public partial class Souhrn : Form
    {
        VyberLetu vLet;
        public Souhrn(VyberLetu _vLet)
        {
            InitializeComponent();
            vLet = _vLet;

            nastavFormular();
            nastavHodnotuRichBox();
        }

        public void nastavFormular()
        {
            tbOdkud.Text = vLet.vybraneLety[0][1];
            tbKam.Text = vLet.vybraneLety[0][2];   //[0] id let [1] odkud [2] kam [3] kdy [4] cena
            tbDen.Text = vLet.vybraneLety[0][3];

            if (!vLet.jc.zjistiTypLetu()) //jen cena tam
            {
                gbZpatecniLet.Visible = false;
                int cena = ziskejPocetZestujicich("dospelak") * int.Parse(vLet.vybraneLety[0][4]) + ziskejPocetZestujicich("senior") * int.Parse(vLet.vybraneLety[0][4]) + ziskejPocetZestujicich("dite") * int.Parse(vLet.vybraneLety[0][4]);
                cena = (vLet.jc.ziskejTriduLetu() + 1) * cena;
                lbCenaVypoctena.Text = cena.ToString();
            }

            else //cena i se zpátečním letem
            {
                tbOdkudZL.Text = vLet.vybraneLety[1][1];
                tbKamZL.Text = vLet.vybraneLety[1][2];   //[0] id let [1] odkud [2] kam [3] kdy [4] cena
                tbDenZL.Text = vLet.vybraneLety[1][3];

                int cena = ziskejPocetZestujicich("dospelak") * int.Parse(vLet.vybraneLety[0][4]) + ziskejPocetZestujicich("senior") * int.Parse(vLet.vybraneLety[0][4]) + ziskejPocetZestujicich("dite") * int.Parse(vLet.vybraneLety[1][4]) + ziskejPocetZestujicich("dospelak") * int.Parse(vLet.vybraneLety[1][4]) + ziskejPocetZestujicich("senior") * int.Parse(vLet.vybraneLety[1][4]) + ziskejPocetZestujicich("dite") * int.Parse(vLet.vybraneLety[1][4]);
                cena = (vLet.jc.ziskejTriduLetu() + 1) * cena;
                lbCenaVypoctena.Text = cena.ToString();
            }

            
        }


            


        public int ziskejPocetZestujicich(string cestujici)
        {
            int i = 0;
            if (cestujici == "dospelak")
            {
                foreach (var item in vLet.jc.osoby)
                {
                    if (item.typ == "dospelak")
                    {
                        i++;
                    }
                }
                return i;
            }

            else if (cestujici == "senior")
            {
                foreach (var item in vLet.jc.osoby)
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
                foreach (var item in vLet.jc.osoby)
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
            rtbCestujici.AppendText(String.Format("Dospělí: {0}{1}", ziskejPocetZestujicich("dospelak"), Environment.NewLine));
            rtbCestujici.AppendText(String.Format("Senioři: {0}{1}", ziskejPocetZestujicich("senior"), Environment.NewLine));
            rtbCestujici.AppendText(String.Format("Děti: {0}{1}", ziskejPocetZestujicich("dite"), Environment.NewLine));
        }



        private void buttObjednat_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("přejeme příjemný let");
            vLet.jc.Close();
        }

        private void Souhrn_Load(object sender, EventArgs e)
        {

        }

        private void buttStorno_Click(object sender, EventArgs e)
        {
            this.Close();
            vLet.jc.Show();
        }
    }
}
