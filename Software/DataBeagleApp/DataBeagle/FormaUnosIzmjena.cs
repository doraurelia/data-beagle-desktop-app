using DataBeagle.Models;
using DataBeagle.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBeagle
{
    public partial class FormaUnosIzmjena : Form
    {
        private Zivotinja zivotinja;
        public FormaUnosIzmjena()
        {
            InitializeComponent();
            cmbxVrsta.DataSource = RepozitorijVrsta.GetVrste();
            cmbxVrsta.DisplayMember = "Naziv";
            cmbxVrsta.ValueMember = "id";
            cmbxUdomljena.DataSource = new List<string> 
            { 
                "Ne", 
                "Da" 
            };
        }

        public FormaUnosIzmjena(Zivotinja odabranaZivotinja) : this() 
        {
            zivotinja = odabranaZivotinja;

            if (zivotinja == null) return;

            txtIme.Text = zivotinja.ime;
            dtpDatumDolaska.Value = zivotinja.datumDolaska;
            dtpDatumRodjenja.Value = zivotinja.datumRodjenja;
            if (zivotinja.vrsta != null) cmbxVrsta.SelectedValue = zivotinja.vrsta.id;
            cmbxUdomljena.SelectedItem = zivotinja.udomljena ? "Da" : "Ne";

            if (zivotinja.udomljena)
            {
                txtUdomitelj.Text = zivotinja.oibUdomitelj;
                dtpDatumUdomljenja.Value = zivotinja.datumUdomljenja.Value;
               
            }
            else
            {
                txtUdomitelj.Text = "";
                dtpDatumUdomljenja.Value = DateTime.Now; 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (dtpDatumDolaska.Value < dtpDatumRodjenja.Value ||
                dtpDatumDolaska.Value > dtpDatumUdomljenja.Value ||
                dtpDatumUdomljenja.Value < dtpDatumRodjenja.Value //provjeri još da ako je udomljena budu uneseni i datum i udomitelj
                )
            {
                //ne dopusti unos
            }
            else
            {
                //spremi podatke u bazu
                //osvježi formu za pregled
            }

        }

        private void cmbxUdomitelj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUdomitelj_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormaUnosIzmjena_Load(object sender, EventArgs e)
        {
            
        }
    }
}
