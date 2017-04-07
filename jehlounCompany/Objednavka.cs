using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jehlounCompany
{
    public class Objednavka
    {
        public List<Let> vybraneLety;
        public string trida { get; set; }

        public Objednavka(string _trida)
        {
            vybraneLety = new List<Let>();
            this.trida = _trida;
        }

    }
}
