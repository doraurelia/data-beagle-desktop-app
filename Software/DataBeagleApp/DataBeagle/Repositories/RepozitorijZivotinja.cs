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

        public static Zivotinja GetZivotinja(string ime)
        {
            Zivotinja zivotinja = null;
            string sql = $"SELECT * FROM dbo.Zivotinja WHERE Ime_zivotinje = '{ime}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                zivotinja = CreateObject(reader);
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
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            string sql = $"SELECT * FROM Zivotinja WHERE ID_vrsta = {idVrsta}";
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

        public static List<Zivotinja> GetUdomljene()
        {
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            string sql = "SELECT * FROM Zivotinja WHERE Udomljena = 'True'";
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

        public static List<Zivotinja> GetUdomljeneFilter(DateTime pocetak, DateTime kraj)
        {
            List<Zivotinja> zivotinje = new List<Zivotinja>();
            string sql = $"SELECT * FROM Zivotinja WHERE Datum_dolaska >= '{pocetak:yyyy-MM-dd}' AND Datum_dolaska <= '{kraj:yyyy-MM-dd}' AND Udomljena = 'True'";
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
            string ImeZivotinje = reader["Ime_zivotinje"].ToString();
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
                oibUdomitelj = OibUdomitelja
            };
            return zivotinja;
        }

        public static void InsertZivotinja (Zivotinja zivotinja)
        {
            int udomljenaSql = zivotinja.udomljena ? 1 : 0;
            string sql;
            if (udomljenaSql == 1)
            {
                sql = $"INSERT INTO Zivotinja (Ime_zivotinje, Datum_rodjenja, Datum_dolaska, Udomljena, Datum_udomljenja, ID_vrsta, OIB_udomitelj) VALUES ('{zivotinja.ime}', '{zivotinja.datumRodjenja:yyyy-MM-dd}', '{zivotinja.datumDolaska:yyyy-MM-dd}', {udomljenaSql}, '{zivotinja.datumUdomljenja:yyyy-MM-dd}', {zivotinja.vrsta.id}, '{zivotinja.oibUdomitelj}')";
            }
            else
            {
                sql = $"INSERT INTO Zivotinja (Ime_zivotinje, Datum_rodjenja, Datum_dolaska, Udomljena, Datum_udomljenja, ID_vrsta, OIB_udomitelj) VALUES ('{zivotinja.ime}', '{zivotinja.datumRodjenja:yyyy-MM-dd}', '{zivotinja.datumDolaska:yyyy-MM-dd}', {udomljenaSql}, NULL, {zivotinja.vrsta.id}, NULL)";

            }
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateZivotinja(Zivotinja zivotinja)
        {
            int udomljenaSql = zivotinja.udomljena ? 1 : 0;
            string sql;
            if (zivotinja.udomljena)
            {
                sql = $"UPDATE Zivotinja SET Ime_zivotinje = '{zivotinja.ime}', Datum_rodjenja = '{zivotinja.datumRodjenja:yyyy-MM-dd}', Datum_dolaska = '{zivotinja.datumDolaska:yyyy-MM-dd}', Udomljena = {udomljenaSql}, Datum_udomljenja = '{zivotinja.datumUdomljenja:yyyy-MM-dd}', ID_vrsta = {zivotinja.vrsta.id}, OIB_udomitelj = '{zivotinja.oibUdomitelj}' WHERE ID_zivotinje = {zivotinja.id}";
                //omogućena promjena svega da se može ispraviti u slučaju pogrešnog unosa 
            }
            else
            {
                sql = $"UPDATE Zivotinja SET Ime_zivotinje = '{zivotinja.ime}', Datum_rodjenja = '{zivotinja.datumRodjenja:yyyy-MM-dd}', Datum_dolaska = '{zivotinja.datumDolaska:yyyy-MM-dd}', ID_vrsta = {zivotinja.vrsta.id} WHERE ID_zivotinje = {zivotinja.id}";
            }
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteZivotinja(int id)
        {
            string sql = $"DELETE FROM Zivotinja WHERE ID_zivotinje = {id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
