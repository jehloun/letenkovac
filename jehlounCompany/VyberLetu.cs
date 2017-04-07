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
    public partial class VyberLetu : Form
    {
        public jehlounCompany jc;
        public List<List<string>> vybraneLety = new List<List<string>>();

        public VyberLetu(List<Let> _volneLety, jehlounCompany _jc, List<Let> _volneLetyZpet = null)
        {
            InitializeComponent();
            jc = _jc;

            nactiLety(_volneLety);

            if (_volneLetyZpet != null)
            {
                this.let_grid.Height = 214;
                this.let_grid_return.Visible = true;
                this.lbLetZpet.Visible = true;
                nactiLetyZpet(_volneLetyZpet);
            }

            else
            {
                this.let_grid_return.Visible = false;
                this.lbLetZpet.Visible = false;
                this.let_grid.Height = 450;
            }

        }

        //načte datagrid 1
        private void nactiLety(List<Let> volneLety)
        {
            foreach (Let let in volneLety)
            {
                this.let_grid.Rows.Add(let.id, let.odkud, let.kam, Datab.Instance.FormatDateTo(let.denOdletu), let.cena);
            }
        }

        //načte datagrid 2
        private void nactiLetyZpet(List<Let> volneLety)
        {
            foreach (Let let in volneLety)
            {
                this.let_grid_return.Rows.Add(let.id, let.odkud, let.kam, Datab.Instance.FormatDateTo(let.denOdletu), let.cena);
            }
        }


        //náš vybraný let
        public void ziskejVybranyLet()
        {
            foreach (DataGridViewRow row in let_grid.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                Console.WriteLine(value1);
                string value2 = row.Cells[1].Value.ToString();
                Console.WriteLine(value2);
                string value3 = row.Cells[2].Value.ToString();
                Console.WriteLine(value3);
                string value4 = row.Cells[3].Value.ToString();
                Console.WriteLine(value4);
                string value5 = row.Cells[4].Value.ToString();
                Console.WriteLine(value5);

                List<string> letTam = new List<string>();
                letTam.Add(value1);
                letTam.Add(value2);
                letTam.Add(value3);
                letTam.Add(value4);
                letTam.Add(value5);
                
                vybraneLety.Add(letTam);
            }

        }

        //náš vybraný zpáteční let
        public void ziskejVybranyZpatecniLet()
        {
            foreach (DataGridViewRow row in let_grid_return.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                Console.WriteLine(value1);
                string value2 = row.Cells[1].Value.ToString();
                Console.WriteLine(value2);
                string value3 = row.Cells[2].Value.ToString();
                Console.WriteLine(value3);
                string value4 = row.Cells[3].Value.ToString();
                Console.WriteLine(value4);
                string value5 = row.Cells[4].Value.ToString();
                Console.WriteLine(value5);

                List<string> letZpet = new List<string>();
                letZpet.Add(value1);
                letZpet.Add(value2);
                letZpet.Add(value3);
                letZpet.Add(value4);
                letZpet.Add(value5);

                vybraneLety.Add(letZpet);
            }

        }

        public void vytvorSouhrn()
        {
            Souhrn souhr = new Souhrn(this);
            this.Close();
            souhr.Show();
        }

        private void buttVybratLet_Click(object sender, EventArgs e)
        {
            ziskejVybranyLet();
            if (vybraneLety.Count != 0)
            {
                if (jc.zjistiTypLetu())
                {
                    ziskejVybranyZpatecniLet();

                }
                int x = 0;
                foreach (var osoba in jc.osoby)
                {
                    x++;

                    Console.WriteLine(osoba.typ);
                    udajeOsoby udaj;
                    if (x != 1)
                    {
                        udaj = new udajeOsoby(this, osoba.typ, true, osoba);
                        if (udaj.ShowDialog() == DialogResult.OK)
                        {
                            if (jc.osoby.Count == x)
                            {
                                vytvorSouhrn();

                            }
                        }
                    }

                    else
                    {
                        udaj = new udajeOsoby(this, osoba.typ, false, osoba);
                        if (udaj.ShowDialog() == DialogResult.OK)
                        {
                            if (jc.osoby.Count == x)
                            {

                                vytvorSouhrn();
                            }
                        }
                    }


                }
            } 
            else
            {
                MessageBox.Show("zvolte prosím Váš let");
            }
            
        }

        private void VyberLetu_Load(object sender, EventArgs e)
        {

        }
    }
}
