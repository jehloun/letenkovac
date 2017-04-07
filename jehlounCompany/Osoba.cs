using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jehlounCompany
{
    public class Osoba
    {
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public int pohlavi { get; set; }
        public string typ { get; set; } // -- dite/dospeli/senior
        public DateTime datumNarozeni { get; set; }
        public string cisloDokladu { get; set; }
        private string adresa { get; set; }
        private int telefon { get; set; }
        private string email { get; set; }


        public void naplnOsobu(string _jmeno, string _prijmeni, int _pohlavi, string _typ, DateTime _datumNarozeni, string _cisloDokladu, string _adresa, int _telefon, string _email)
        {
            this.jmeno = _jmeno;
            this.prijmeni = _prijmeni;
            this.pohlavi = _pohlavi;
            this.typ = _typ;
            this.datumNarozeni = _datumNarozeni;
            this.cisloDokladu = _cisloDokladu;
            this.adresa = _adresa;
            this.telefon = _telefon;
            this.email = _email;

        }

        public void urciTyp(string _typ)
        {
            typ = _typ;
        }

    }
}
