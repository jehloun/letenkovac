using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letenkovač
{
    public class GNr
    {


        private static GNr instance;

        private GNr() { }

        public static GNr Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GNr();
                }
                return instance;
            }
        }


        public void GenerujLet(int max_dni, int count)
        {
            Console.WriteLine("Generuji nové lety");
            string base_sql = @"insert into tbLet (start_destinace, cilova_destinace, letadlo, datum_odletu, cena) values (";
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                string sql = base_sql;
                //Console.WriteLine(i + " cislo letu");
                int fromD = rnd.Next(247);
                int toD = rnd.Next(247);
                DateTime date = DateTime.Now.AddDays(rnd.Next(max_dni));
                date.AddHours(rnd.Next(max_dni));
                date.AddMinutes(rnd.Next(max_dni));
                sql = sql + fromD + "," + toD + "," + 1 + ", '" + DBo.Instance.FormatDateTo(date) + "', " + rnd.Next(10000);
                sql += ");";
                //Console.WriteLine(sql);
                DBo.Instance.QueryWithoutResult(sql);
            }
        }
    }
}
