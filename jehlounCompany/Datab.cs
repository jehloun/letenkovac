using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace jehlounCompany
{
    public class Datab
    {
        private static Datab instance;

        private Datab() { }

        public static Datab Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Datab();
                }
                return instance;
            }
        }

        private bool configured = false;
        private string path_to_database = "";
        private SQLiteConnection connection;

        /// <summary>
        /// NEPOUZIVAT, JEN PRO TESTOVACI UCEL, ZABLOKUJE PRISTUP K DATABAZI OSTATNIM (PRAVDEPODOBNE)
        /// </summary>
        /// <param name="_path">NEVYUZIVAT!</param>
        public void Configure(string _path)
        {
            if (_path.Length != 0)
            {
                configured = true;
                path_to_database = _path;
                connection = new SQLiteConnection(@"Data Source=" + path_to_database + ";Version=3;FailIfMissing=True;");
            }
        }

        public List<Row> SelectQuery(string sql)
        {
            if (!configured) throw new Exception();
            connection.Open();
            List<Row> list = new List<Row>();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                Console.WriteLine("spoustim query");
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine(reader.FieldCount);
                    while (reader.Read())
                    {
                        Row row = new Row();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.hodnoty.Add(reader[i].ToString());
                        }
                        list.Add(row);
                    }
                }
            }
            connection.Close();
            return list;
        }

        public List<RowWithName> SelectQueryWithColumnName(string sql)
        {
            if (!configured) throw new Exception();
            connection.Open();
            List<RowWithName> list = new List<RowWithName>();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                Console.WriteLine("spoustim query");
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine(reader.FieldCount);
                    while (reader.Read())
                    {
                        RowWithName row = new RowWithName();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.hodnoty.Add(reader.GetOriginalName(i), reader[i].ToString());
                        }
                        list.Add(row);
                    }
                }
            }
            connection.Close();
            return list;
        }

        public void QueryWithoutResult(string sql)
        {
            connection.Open();
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, this.connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                connection.Close();
            }
        }

        public string FormatDateTo(DateTime date)
        {
            return date.Year + "-" + date.Month + "-" + date.Day + " " + date.Hour + ":" + date.Minute;
        }
    }
    public class Row
    {
        public List<string> hodnoty;
        public Row() { hodnoty = new List<string>(); }
    }
    public class RowWithName
    {
        public Dictionary<string, string> hodnoty;
        public RowWithName()
        {
            hodnoty = new Dictionary<string, string>();
        }
    }
}
