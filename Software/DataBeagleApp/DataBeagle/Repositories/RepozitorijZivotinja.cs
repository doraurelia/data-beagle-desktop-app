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
    public class RepozitorijZivotinja
    {
        public static Zivotinja GetZivotinja (int id)
        {
            Zivotinja zivotinja = null;
            string sql = $"SELECT * FROM dbo.Zivotinja WHERE ID_zivotinje = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zivotinja=CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return zivotinja;
        }
        public static List<Zivotinja> GetZivotinje()
        {
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            string sql = "SELECT * FROM dbo.Zivotinja";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);

            while (reader.Read())
            {
                Zivotinja zivotinja = CreateObject(reader);
                zivotinje.Add(zivotinja);
            }

            reader.Close();
            DB.CloseConnection();
            return zivotinje;

        }

        public static List <Zivotinja> GetZivotinjeFilter(int idVrsta)
        {
            List<Zivotinja> zivotinje = null;
            string sql = $"SELECT * FROM Zivotinja WHERE ID_vrsta == {idVrsta}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Zivotinja zivotinja= CreateObject(reader);
                zivotinje.Add(zivotinja);
            }
            reader.Close();
            DB.CloseConnection() ;
            return zivotinje;
        }

        private static Zivotinja CreateObject(SqlDataReader reader)
        {
            int Id = int.Parse(reader["ID_zivotinje"].ToString());
            string ImeZivotinje = reader["Ime_Zivotinje"].ToString();
            DateTime DatumRodjenja = DateTime.Parse(reader["Datum_rodjenja"].ToString());
            DateTime DatumDolaska = DateTime.Parse(reader["Datum_dolaska"].ToString());
            bool.TryParse(reader["Udomljena"].ToString(), out bool Udomljena);
            DateTime? DatumUdomljenja = null;
            string OibUdomitelja = null;
            Vrsta vrstaZivotinje = RepozitorijVrsta.GetVrsta(int.Parse(reader["ID_vrsta"].ToString()));
            if (Udomljena)
            {
                DatumUdomljenja = DateTime.Parse(reader["Datum_udomljenja"].ToString());
                OibUdomitelja = reader["OIB_udomitelj"].ToString();
            }

            var zivotinja = new Zivotinja
            {
                id = Id,
                ime = ImeZivotinje,
                vrsta = vrstaZivotinje,
                udomljena = Udomljena,
                datumDolaska = DatumDolaska,
                datumRodjenja = DatumRodjenja,
                datumUdomljenja = DatumUdomljenja,
            };
            return zivotinja;
        }
    }
}
