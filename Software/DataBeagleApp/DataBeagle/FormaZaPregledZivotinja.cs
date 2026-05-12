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
    public partial class FormaZaPregledZivotinja : Form
    {
        public FormaZaPregledZivotinja()
        {
            InitializeComponent();
        }

        private void filterVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormaUnosIzmjena formaUnosIzmjena = new FormaUnosIzmjena();
            formaUnosIzmjena.ShowDialog();
        }

        private void FormaZaPregledZivotinja_Load(object sender, EventArgs e)
        {
            PrikaziZivotinje();
            cbxFilterVrsta.DataSource = RepozitorijVrsta.GetVrste();
        }

        private void PrikaziZivotinje()
        {
            List<Zivotinja> zivotinje = RepozitorijZivotinja.GetZivotinje();
            dgvZivotinje.DataSource= zivotinje;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            FormaUnosIzmjena formaUnosIzmjena = new FormaUnosIzmjena();
            formaUnosIzmjena.ShowDialog();
        }

        private void dgvZivotinje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            if (cbxFilterVrsta.SelectedValue != null)
            {

            }
        }
    }
}
