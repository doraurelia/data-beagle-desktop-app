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
    public partial class frmPrikazUdomljene : Form
    {
        public frmPrikazUdomljene()
        {
            InitializeComponent();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {

        }

        private void frmPrikazUdomljene_Load(object sender, EventArgs e)
        {
            dgvUdomljene.DataSource = RepozitorijZivotinja.GetUdomljene();
        }
    }
}
