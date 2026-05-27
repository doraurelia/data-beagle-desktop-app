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

      

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;

            DateTime rodjenje = dtpDatumRodjenja.Value;
            DateTime dolazak = dtpDatumDolaska.Value;

            bool udomljena;
            DateTime? udomljenje = null;
            string udomitelj = null;

            if (cmbxUdomljena.SelectedValue.ToString() == "Da")
            {
                udomljena = true;
                //zbog datetimepickera datum svakako postoji pa se ne mora provjeravati null
                if (dtpDatumUdomljenja.Value < rodjenje || dtpDatumUdomljenja.Value < dolazak)
                {
                    MessageBox.Show("Unesite valjane datume, datum udomljenja mora biti nakon datuma dolaska i rođenja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else udomljenje = dtpDatumUdomljenja.Value;

                if(txtUdomitelj.Text == null || txtUdomitelj.Text == "")
                {
                    MessageBox.Show("Ako je životinja udomljena, obvezno unesite OIB udomitelja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else udomitelj = txtUdomitelj.Text;
            }
            else
            {
                udomljena = false;
            }

            if (ime == null || ime == "")
            {
                MessageBox.Show("Ime životinje je obavezno!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(dolazak < rodjenje)
            {
                MessageBox.Show("Datum dolaska ne može biti prije datuma rođenja životinje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (zivotinja == null)
                {
                    zivotinja = new Zivotinja()
                    {
                        id = 0,
                        ime = ime,
                        datumRodjenja = rodjenje,
                        datumDolaska = dolazak,
                        vrsta = cmbxVrsta.SelectedItem as Vrsta,
                        udomljena = udomljena,
                        datumUdomljenja = udomljenje,
                        oibUdomitelj = udomitelj,
                    }; 

                    RepozitorijZivotinja.InsertZivotinja(zivotinja);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    zivotinja.ime = ime;
                    zivotinja.vrsta = cmbxVrsta.SelectedItem as Vrsta;
                    zivotinja.udomljena = udomljena;
                    zivotinja.datumRodjenja = rodjenje;
                    zivotinja.datumDolaska = dolazak;
                    zivotinja.datumUdomljenja = udomljenje;
                    zivotinja.oibUdomitelj = udomitelj;

                    RepozitorijZivotinja.UpdateZivotinja(zivotinja);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }                
            }
            
            
                
            }

    }
}
