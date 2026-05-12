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
        public FormaUnosIzmjena()
        {
            InitializeComponent();
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
            cmbxUdomljena.DataSource = new List<string>
            {
                "Ne",
                "Da"
            }; //pazi kod spremanja da se spremi bool ne string
            cmbxVrsta.DataSource = RepozitorijVrsta.GetVrste();
        }
    }
}
