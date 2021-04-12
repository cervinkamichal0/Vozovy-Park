using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozový_park
{
    public partial class fAlert : Form
    {
        public static bool potvrzeni;
        public fAlert()
        {
            InitializeComponent();
        }
        private void bAno_Click(object sender, EventArgs e)
        {
            potvrzeni = true;
            this.Close();
        }

        private void bNe_Click(object sender, EventArgs e)
        {
            potvrzeni = false;
            this.Close();
        }

        private void fAlert_Load(object sender, EventArgs e)
        {
            potvrzeni = false;
        }
    }
}
