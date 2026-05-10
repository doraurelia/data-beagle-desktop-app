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

        private static Zivotinja CreateObject(SqlDataReader reader)
        {
            int Id = int.Parse(reader["ID_zivotinje"].ToString());
            string ImeZivotinje = reader["Ime_Zivotinje"].ToString();
            DateTime DatumRodjenja = DateTime.Parse(reader["Datum_rodjenja"].ToString());
            DateTime DatumDolaska = DateTime.Parse(reader["Datum_dolaska"].ToString());
            bool Udomljena = bool.TryParse(reader["Udomljena"].ToString(), out bool udomljena);
            DateTime? DatumUdomljenja = null;
            string OibUdomitelja = null;
            //treba još vrstu dohvatiti
            if (Udomljena)
            {
                DatumUdomljenja = DateTime.Parse(reader["Datum_udomljenja"].ToString());
                OibUdomitelja = reader["OIB_udomitelj"].ToString();
            }

            var zivotinja = new Zivotinja
            {
                id = Id,
                ime = ImeZivotinje,
                //vrstu treba dodati
                vrsta = null,
                udomljena = Udomljena,
                datumDolaska = DatumDolaska,
                datumRodjenja = DatumRodjenja,
                datumUdomljenja = DatumUdomljenja,
            };
            return zivotinja;
        }
    }
}
