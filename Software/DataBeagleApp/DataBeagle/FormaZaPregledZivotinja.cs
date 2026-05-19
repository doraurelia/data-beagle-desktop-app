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
            if (formaUnosIzmjena.ShowDialog() == DialogResult.OK)
            {
                PrikaziZivotinje();
            }
        }

        private void FormaZaPregledZivotinja_Load(object sender, EventArgs e)
        {
            PrikaziZivotinje();
            List<Vrsta> vrste = new List<Vrsta>();
            vrste = RepozitorijVrsta.GetVrste();
            vrste.Insert(0, new Vrsta { id = 0, naziv = "--- Sve vrste ---" });
            cbxFilterVrsta.DataSource = vrste;
            cbxFilterVrsta.DisplayMember = "naziv"; 
            cbxFilterVrsta.ValueMember = "id";
            btnIzvjestaj.Visible = false;
            dtpPocetak.Visible = false;
            dtpKraj.Visible = false;
            lblPocetak.Visible = false;
            lblKraj.Visible = false;
            dgvZivotinje.ReadOnly=true;
            dtpPocetak.Value = DateTime.Parse("1.1.2018.");
        }

        private void PrikaziZivotinje()
        {
            List<Zivotinja> zivotinje = RepozitorijZivotinja.GetZivotinje();
            dgvZivotinje.DataSource= zivotinje;
            dgvZivotinje.Columns[0].HeaderText = "ID";
            dgvZivotinje.Columns[1].HeaderText = "Ime";
            dgvZivotinje.Columns[2].HeaderText = "Vrsta";
            dgvZivotinje.Columns[3].HeaderText = "Udomljena";
            dgvZivotinje.Columns[4].HeaderText = "Datum rođenja";
            dgvZivotinje.Columns[5].HeaderText = "Datum dolaska";
            dgvZivotinje.Columns[6].HeaderText = "Datum udomljenja";
            dgvZivotinje.Columns[7].HeaderText = "OIB Udomitelja";
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            if (dgvZivotinje.SelectedRows != null) {
                var odabranaZivotinja = dgvZivotinje.SelectedRows[0].DataBoundItem as Zivotinja;
                FormaUnosIzmjena formaUnosIzmjena = new FormaUnosIzmjena(odabranaZivotinja);
                if (formaUnosIzmjena.ShowDialog() == DialogResult.OK)
                {
                    PrikaziZivotinje();
                }
            }
        
        
        }

        private void dgvZivotinje_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            if (cbxFilterVrsta.SelectedValue != null)
            {
                if ((int)cbxFilterVrsta.SelectedValue != 0) 
                {
                    dgvZivotinje.DataSource = RepozitorijZivotinja.GetZivotinjeFilter((int)cbxFilterVrsta.SelectedValue);
                    
                }
                else
                {
                    dgvZivotinje.DataSource = RepozitorijZivotinja.GetZivotinje();
                }
               
            }
            else
            {
                dgvZivotinje.DataSource = RepozitorijZivotinja.GetZivotinje();
            }
        }

        private void btnUdomljene_Click(object sender, EventArgs e)
        {
            if(btnUdomljene.Text=="Udomljene životinje")
            {
                dgvZivotinje.DataSource = RepozitorijZivotinja.GetUdomljene();
                lblNaslov.Text = "Udomljene životinje";
                btnUdomljene.Text = "Sve životinje";
                btnIzvjestaj.Visible = true;
                dtpPocetak.Visible = true;
                dtpKraj.Visible = true;
                lblPocetak.Visible = true;
                lblKraj.Visible = true;
                btnFiltriraj.Visible = false;
                cbxFilterVrsta.Visible = false;
            }
            else
            {
                dgvZivotinje.DataSource = RepozitorijZivotinja.GetZivotinje();
                lblNaslov.Text = "Životinje u skloništu";
                btnUdomljene.Text = "Udomljene životinje";
                btnIzvjestaj.Visible = false;
                dtpPocetak.Visible = false;
                dtpKraj.Visible = false;
                lblPocetak.Visible = false;
                lblKraj.Visible = false;
                btnFiltriraj.Visible = true;
                cbxFilterVrsta.Visible = true;
            }
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            if(dtpPocetak.Value <= dtpKraj.Value)
            {
                FrmIzvjestaj frmIzvjestaj = new FrmIzvjestaj(dtpPocetak.Value, dtpKraj.Value);
                frmIzvjestaj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Početni datum mora biti prije završnog!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (dgvZivotinje.SelectedRows != null)
            {
                var odabranaZivotinja = dgvZivotinje.SelectedRows[0].DataBoundItem as Zivotinja;
                RepozitorijZivotinja.DeleteZivotinja(odabranaZivotinja.id);
                PrikaziZivotinje();
            }
        }
    }
}


