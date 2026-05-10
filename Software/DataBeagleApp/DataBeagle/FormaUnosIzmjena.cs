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
            if (dtpDatumDolaska.Value < dtpDatumRodjenja.Value || dtpDatumDolaska.Value > dtpDatumUdomljenja.Value || dtpDatumUdomljenja.Value < dtpDatumRodjenja.Value)
            {
                //ne dopusti unos
            }else
            {
                //spremi podatke u bazu
                //osvježi formu za pregled
            }
           
        }
    }
}
