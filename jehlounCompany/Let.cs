using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jehlounCompany
{
    public class Let
    {
        public int id { get; set; }
        public int odkudIndex { get; set; }
        public string odkud { get; set; }
        public int kamIndex { get; set; }
        public string kam { get; set; }

        public int letadlo { get; set; }
        public DateTime denOdletu { get; set; }
        public int cena { get; set; }

        public Let(int _id, int _odkudIndex, string _odkud, int _kamIndex, string _kam, int _letadlo, DateTime _denOdletu, int _cena)
        {
            this.id = _id;
            this.odkudIndex = _odkudIndex;
            this.odkud = _odkud;
            this.kamIndex = _kamIndex;
            this.kam = _kam;
            this.letadlo = _letadlo;
            this.denOdletu = _denOdletu;
            this.cena = _cena;

        }
    }
}
