using DataBeagle.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBeagle.Repositories
{
    internal class RepozitorijVrsta
    {
        public static Vrsta GetVrsta(int id)
        {
            Vrsta vrsta = null;
            string sql = $"SELECT * FROM dbo.Vrsta WHERE ID_vrste = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vrsta = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return vrsta;
        }
        public static List<Vrsta> GetVrste()
        {
            List<Vrsta> vrste = new List<Vrsta>();
            string sql = "SELECT * FROM dbo.Vrsta";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Vrsta vrsta = CreateObject(reader);
                vrste.Add(vrsta);
            }

            reader.Close();
            DB.CloseConnection();
            return vrste;

        }

        private static Vrsta CreateObject(SqlDataReader reader)
        {
            int Id = int.Parse(reader["ID_vrste"].ToString());
            string Naziv = reader["Naziv_vrste"].ToString();
            
            var vrsta = new Vrsta
            {
                id = Id,
                naziv = Naziv,
            };
            return vrsta;
        }
    }
}
