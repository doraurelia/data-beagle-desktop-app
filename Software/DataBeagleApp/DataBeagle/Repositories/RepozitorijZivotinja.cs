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
            string sql = $"INSERT INTO Zivotinja (Ime_zivotinje, Datum_rodjenja, Datum_dolaska, Udomljena, Datum_udomljenja, ID_vrsta, OIB_udomitelj) VALUES ({zivotinja.ime}, {zivotinja.datumRodjenja}, {zivotinja.datumDolaska}, {zivotinja.udomljena}, {zivotinja.datumUdomljenja}, {zivotinja.vrsta.id}, {zivotinja.oibUdomitelj})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateZivotinja(Zivotinja zivotinja)
        {
            string sql = $"UPDATE Zivotinja SET Ime_zivotinje = {zivotinja.ime}, Datum_rodjenja = {zivotinja.datumRodjenja}, Datum_dolaska = {zivotinja.datumDolaska}, Udomljena = {zivotinja.udomljena}, Datum_udomljenja = {zivotinja.datumUdomljenja}, ID_vrsta = {zivotinja.vrsta.id}, OIB_udomitelj = {zivotinja.oibUdomitelj} WHERE ID_zivotinje = {zivotinja.id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
