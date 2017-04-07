using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jehlounCompany
{
    public partial class udajeOsoby : Form
    {
        VyberLetu vyb;
        Osoba osoba;
        private bool _valid = false;
        private bool dalsiInfo;
        public udajeOsoby(VyberLetu _vyb, string _typ, bool _dalsiInfo, Osoba _osoba)
        {
            InitializeComponent();
            this.vyb = _vyb;
            this.osoba = _osoba;
            lbTyp.Text = _typ;
            this.dalsiInfo = _dalsiInfo;
            if (dalsiInfo)
            {
                lbEmail.Visible = false;
                tbEmail.Visible = false;
                lbTelefon.Visible = false;
                tbTelefon.Visible = false;
                lbUlice.Visible = false;
                tbUlice.Visible = false;
                lbMesto.Visible = false;
                tbMesto.Visible = false;
                
            }


        }

        private void TbCisloPrukazu_Validating(object sender, CancelEventArgs e)
        {
        }

        private bool IsValid()
        {
            bool valid = true;
            this.errorProvider.Clear();

            // jmeno
            if (string.IsNullOrWhiteSpace(this.tbJmeno.Text))
            {
                valid = false;
                this.errorProvider.SetError(this.tbJmeno, "Nesmi byt prazdne");
            }

            // prijmeni
            if (string.IsNullOrWhiteSpace(this.tbPrijmeni.Text))
            {
                valid = false;
                this.errorProvider.SetError(this.tbPrijmeni, "Nesmi byt prazdne");
            }

            // pohlavi
            if (string.IsNullOrWhiteSpace(this.cbPohlavi.Text))
            {
                valid = false;
                this.errorProvider.SetError(this.cbPohlavi, "Nesmi byt prazdne");
            }

            //datum narození


            if(!dalsiInfo)
            {
                //telefon
                if (!Regex.IsMatch(this.tbTelefon.Text, @"^[0-9]{9}$"))
                {
                    valid = false;
                    this.errorProvider.SetError(this.tbTelefon, "Spatně napsané");
                }

                //email
                if (!Regex.IsMatch(this.tbEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    valid = false;
                    this.errorProvider.SetError(this.tbEmail, "Spatně napsané");
                }

                //mesto
                if (string.IsNullOrWhiteSpace(this.tbMesto.Text))
                {
                    valid = false;
                    this.errorProvider.SetError(this.tbMesto, "Nesmi byt prazdne");
                }

                //ulice
                if (string.IsNullOrWhiteSpace(this.tbUlice.Text))
                {
                    valid = false;
                    this.errorProvider.SetError(this.tbUlice, "Nesmi byt prazdne");
                }
            }


            //číslo průkoz
            if (!Regex.IsMatch(this.tbCisloPrukazu.Text, @"^[a-zA-Z0-9/]{5,20}$"))
            {
                valid = false;
                this.errorProvider.SetError(this.tbCisloPrukazu, "min délka: 5 max délka: 20");
            }

            return valid;
        }


        private void buttDalsi_Click(object sender, EventArgs e)
        {
            if (this.IsValid())
            {
                this.DialogResult = DialogResult.OK;
                tbTelefon.Text = "000"; //ošetření chyby, která nastane, když je telefon jako nepovinný údaj
                osoba.naplnOsobu(tbJmeno.Text, tbPrijmeni.Text, cbPohlavi.SelectedIndex, this.lbTyp.Text, dtpDatumNarozeni.Value, tbCisloPrukazu.Text, tbMesto.Text + " " + tbUlice.Text, int.Parse(tbTelefon.Text), tbEmail.Text);
                this.Close();
            }

        }

        private void udajeOsoby_Load(object sender, EventArgs e)
        {
            
        }

        private void ziskejData()
        {

        }

        private void tbJmeno_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.tbJmeno, null);
            if (string.IsNullOrWhiteSpace(this.tbJmeno.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbJmeno, "Nesmi byt prazdne");
            }
        }

        private void tbPrijmeni_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.tbPrijmeni, null);
            if (string.IsNullOrWhiteSpace(this.tbPrijmeni.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbPrijmeni, "Nesmi byt prazdne");
            }
        }

        private void cbPohlavi_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.cbPohlavi, null);
            if (string.IsNullOrWhiteSpace(this.cbPohlavi.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.cbPohlavi, "Nesmi byt prazdne");
            }
        }


        private void tbTelefon_Validated(object sender, EventArgs e)
        {
            this.errorProvider.SetError(this.tbTelefon, null);
            if (string.IsNullOrWhiteSpace(this.tbTelefon.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbTelefon, "Nesmi byt prazdne");
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.tbEmail, null);
            if (string.IsNullOrWhiteSpace(this.tbEmail.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbEmail, "Nesmi byt prazdne");
            }
        }

    private void tbMesto_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.tbMesto, null);
            if (string.IsNullOrWhiteSpace(this.tbMesto.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbMesto, "Nesmi byt prazdne");
            }
        }

        private void tbUlice_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.tbUlice, null);
            if (string.IsNullOrWhiteSpace(this.tbUlice.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbUlice, "Nesmi byt prazdne");
            }
        }

        private void tbCisloPrukazu_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.tbCisloPrukazu, null);
            if (string.IsNullOrWhiteSpace(this.tbCisloPrukazu.Text))
            {
                this._valid = false;
                this.errorProvider.SetError(this.tbCisloPrukazu, "Nesmi byt prazdne");
            }
        }
    }
}
