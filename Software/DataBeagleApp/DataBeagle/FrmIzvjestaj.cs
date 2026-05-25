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
    public partial class FrmIzvjestaj : Form
    {
        private DateTime odabraniPocetak;
        private DateTime odabraniKraj;
        public FrmIzvjestaj(DateTime pocetak, DateTime kraj)
        {
            odabraniPocetak = pocetak;
            odabraniKraj = kraj;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmIzvjestaj_Load(object sender, EventArgs e)
        {
            
            lblPocetak.Text = odabraniPocetak.ToShortDateString();
            lblKraj.Text = odabraniKraj.ToShortDateString();
            dgvUdomljene.ReadOnly = true;
            PrikaziZivotinje();
        }

        private void PrikaziZivotinje()
        {
            List<Zivotinja> zivotinje = RepozitorijZivotinja.GetUdomljeneFilter(odabraniPocetak, odabraniKraj);
            dgvUdomljene.DataSource = zivotinje;
            dgvUdomljene.Columns[0].HeaderText = "ID";
            dgvUdomljene.Columns[1].HeaderText = "Ime";
            dgvUdomljene.Columns[2].HeaderText = "Vrsta";
            dgvUdomljene.Columns[3].HeaderText = "Udomljena";
            dgvUdomljene.Columns[4].HeaderText = "Datum rođenja";
            dgvUdomljene.Columns[5].HeaderText = "Datum dolaska";
            dgvUdomljene.Columns[6].HeaderText = "Datum udomljenja";
            dgvUdomljene.Columns[7].HeaderText = "OIB Udomitelja";
            PrilagodiVisinuTablice();
        }

        private void PrilagodiVisinuTablice()
        {
            int ukupnaVisina = dgvUdomljene.ColumnHeadersHeight;
            foreach (DataGridViewRow row in dgvUdomljene.Rows)
            {
                if (row.Visible)
                {
                    ukupnaVisina += row.Height;
                }
            }
            ukupnaVisina += (dgvUdomljene.BorderStyle == BorderStyle.None) ? 2 : 4;
            dgvUdomljene.Height = ukupnaVisina < 350 ? ukupnaVisina : 350;
        }

        private void dgvUdomljene_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
