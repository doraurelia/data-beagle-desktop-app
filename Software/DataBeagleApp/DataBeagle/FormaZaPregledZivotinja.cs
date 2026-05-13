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
            List<Vrsta> vrste = new List<Vrsta>();
            vrste = RepozitorijVrsta.GetVrste();
            vrste.Insert(0, new Vrsta { id = 0, naziv = "--- Sve vrste ---" });
            cbxFilterVrsta.DataSource = vrste;
            cbxFilterVrsta.DisplayMember = "naziv"; 
            cbxFilterVrsta.ValueMember = "id";     
        }

        private void PrikaziZivotinje()
        {
            List<Zivotinja> zivotinje = RepozitorijZivotinja.GetZivotinje();
            dgvZivotinje.DataSource= zivotinje;
        }

        private void btnIzmijeni_Click(object sender, EventArgs e)
        {
            if (dgvZivotinje.SelectedRows != null) {
                var odabranaZivotinja = dgvZivotinje.SelectedRows[0].DataBoundItem as Zivotinja;
                FormaUnosIzmjena formaUnosIzmjena = new FormaUnosIzmjena(odabranaZivotinja);
                formaUnosIzmjena.ShowDialog(); 
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
            }
            else
            {
                dgvZivotinje.DataSource = RepozitorijZivotinja.GetZivotinje();
                lblNaslov.Text = "Životinje u skloništu";
                btnUdomljene.Text = "Udomljene životinje";
            }

        }
    }
}

/*DateTime pocetak = dtpPocetakFilter.Value;
        DateTime kraj = dtpKrajFilter.Value;
            if (pocetak<kraj && kraj <= DateTime.Now)
            {
                dgvZivotinje.DataSource = RepozitorijZivotinja.GetUdomljene(pocetak, kraj);
            }
            else
            {
                dgvZivotinje.DataSource = RepozitorijZivotinja.GetZivotinje();
            }*/
