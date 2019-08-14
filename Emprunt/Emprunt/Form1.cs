using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emprunt
{
    public partial class frmEmprunt : Form
    {
        public frmEmprunt()
        {
            InitializeComponent();
        }

        private void tbxPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEmprunt_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bonjour " + tbxPrenom.Text);
        }
    }
}
