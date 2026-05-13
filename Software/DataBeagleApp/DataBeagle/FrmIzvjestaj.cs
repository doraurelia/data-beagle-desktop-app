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
            dgvUdomljene.DataSource = RepozitorijZivotinja.GetUdomljeneFilter(odabraniPocetak, odabraniKraj);
            lblPocetak.Text=odabraniPocetak.ToString();
            lblKraj.Text=odabraniKraj.ToString();
        }
    }
}
