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
    public partial class Cestujicii : Form
    {
        public jehlounCompany company;

        public Cestujicii(jehlounCompany _company)
        {
            InitializeComponent();
            company = _company;
        }


        private void buttDetiPlus_Click_1(object sender, EventArgs e)
        {
            tbDeti.Text = Convert.ToString(int.Parse(tbDeti.Text) + 1);
        }

        private void buttSenioriPlus_Click_1(object sender, EventArgs e)
        {
            tbSeniori.Text = Convert.ToString(int.Parse(tbSeniori.Text) + 1);
        }

        private void buttDospeliPlus_Click_1(object sender, EventArgs e)
        {
            tbDospeli.Text = Convert.ToString(int.Parse(tbDospeli.Text) + 1);
        }

        private void buttDospeliMinus_Click_1(object sender, EventArgs e)
        {
            tbDospeli.Text = Convert.ToString(int.Parse(tbDospeli.Text) - 1);
            if (int.Parse(tbDospeli.Text) < 0)
            {
                tbDospeli.Text = "0";
            }
        }

        private void buttSenioriMinus_Click_1(object sender, EventArgs e)
        {
            tbSeniori.Text = Convert.ToString(int.Parse(tbSeniori.Text) - 1);
            if (int.Parse(tbSeniori.Text) < 0)
            {
                tbSeniori.Text = "0";
            }
        }

        private void buttDetiMinus_Click_1(object sender, EventArgs e)
        {
            tbDeti.Text = Convert.ToString(int.Parse(tbDeti.Text) - 1);
            if (int.Parse(tbDeti.Text) < 0)
            {
                tbDeti.Text = "0";
            }
        }

        private void buttVybrat_Click_1(object sender, EventArgs e)
        {
            company.vytvorCestujici(int.Parse(tbDospeli.Text), int.Parse(tbDeti.Text), int.Parse(tbSeniori.Text));
            company.nastavHodnotuRichBox();
            this.Close();
        }
    }
}
