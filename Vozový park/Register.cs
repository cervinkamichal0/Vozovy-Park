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
    public partial class fRegister : Form
    {
        Databaze.Uzivatel novyUzivatel = new Databaze.Uzivatel();
        public fRegister()
        {
            InitializeComponent();
        }

        private void bRegistrovat_Click(object sender, EventArgs e)
        {
            if (tBRUzivatelskeJmeno.Text == "" || tBJmeno.Text == "" || tBPrijmeni.Text == "" || tBRHeslo.Text == "" || tBRPotvrzeniHesla.Text == "")
            {
                lVsechnaPoleMusiBytVyplnena.Visible = true;
                return;
            }
            foreach (var v in Databaze.dUzivatele)
            {
                if (tBRUzivatelskeJmeno.Text == v.Key)
                {
                    lUzivatelskeJmenoJeJizZabrane.Visible = true;
                    return;
                }
            }
            if (tBRHeslo.Text == tBRPotvrzeniHesla.Text)
                novyUzivatel.heslo = tBRHeslo.Text.GetHashCode().ToString();
            else
            {
                lHeslaSeNeshodují.Visible = true;
                return;
            }
            novyUzivatel.jmeno = tBJmeno.Text;
            novyUzivatel.prijmeni = tBPrijmeni.Text;
            if (cBAdmin.Checked == true)
                novyUzivatel.admin = true;
            else
                novyUzivatel.admin = false;
            novyUzivatel.aktivni = true;
            Databaze._dUzivatele.Add(tBRUzivatelskeJmeno.Text, novyUzivatel);

            this.Close();
        }

        private void fRegister_Load(object sender, EventArgs e)
        {
            if (Databaze.dUzivatele.Count == 0)
            {
                cBAdmin.Checked = true;
                cBAdmin.Enabled = false;
                lRegistrace.Visible = false;
                lVytvortePrvnihoAdministratora.Visible = true;
            }
        }
    }
}
