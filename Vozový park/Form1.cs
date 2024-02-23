using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vozový_park
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
        }
        private void bPrihlasitSe_Click(object sender, EventArgs e)
        {
            fAdminMenu AdminMenu = new fAdminMenu();
            fUserMenu UserMenu = new fUserMenu();
            string s = tBHeslo.GetHashCode().ToString();
            if (Databaze.dUzivatele.ContainsKey(tBUzivatelskeJmeno.Text) == false || Databaze.dUzivatele[tBUzivatelskeJmeno.Text].heslo != tBHeslo.Text.GetHashCode().ToString())
            {
                lSpatneUdaje.Visible = true;
                return;
            }
            if (Databaze.dUzivatele[tBUzivatelskeJmeno.Text].aktivni == false)
            {
                MessageBox.Show("Váš účet byl deaktivován, kontaktujte administrátora.");
                return;
            }
            Databaze._prihlasenyUzivatel = tBUzivatelskeJmeno.Text;
            if (Databaze.dUzivatele[tBUzivatelskeJmeno.Text].zmenaHesla == true)
            {
                fZmenaHesla zmenaHesla = new fZmenaHesla();
                zmenaHesla.Show();
                return;
            }


            if (Databaze.dUzivatele[tBUzivatelskeJmeno.Text].admin == true)
                AdminMenu.Show();
            else
                UserMenu.Show();
            this.Hide();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter zapisUzivatelu = new StreamWriter("uzivatele.txt");
            foreach (var v in Databaze.dUzivatele)
            {
                zapisUzivatelu.WriteLine(v.Key + ";" + v.Value.jmeno + ";" + v.Value.prijmeni + ";" + v.Value.heslo + ";" + v.Value.posledniPrihlaseni + ";" + v.Value.admin + ";" + v.Value.aktivni + ";" + v.Value.zmenaHesla);
            }
            zapisUzivatelu.Close();


            StreamWriter zapisVozu = new StreamWriter("vozy.txt");
            foreach (var v in Databaze.dVozy)
            {
                zapisVozu.WriteLine(v.Key + ";" + v.Value.vyrobce + ";" + v.Value.model + ";" + v.Value.typ + ";" + v.Value.spotreba.ToString() + ";" + v.Value.aktivni + ";" + v.Value.deaktivovanyOd + ";" + v.Value.deaktivovanyDo);
            }
            zapisVozu.Close();

            StreamWriter zapisServisniKnihy = new StreamWriter("servisniKniha.txt");
            foreach (var v in Databaze.dServisniKniha)
            {
                zapisServisniKnihy.WriteLine(v.idVozu + ";" + v.ukon + ";" + v.cena.ToString() + ";" + v.cisloFaktury + ";" + v.datumACasProvedeni);
            }
            zapisServisniKnihy.Close();


            StreamWriter zapisRezervaci = new StreamWriter("rezervace.txt");
            foreach (var v in Databaze.dRezervace)
            {
                zapisRezervaci.WriteLine(v.idVozu + ";" + v.idUzivatele + ";" + v.rezervaceOd + ";" + v.rezervaceDo + ";" + v.aktivni);
            }
            zapisRezervaci.Close();

            Application.Exit();
        }

        private void fLogin_Shown(object sender, EventArgs e)
        {
            if (Databaze.dUzivatele.Count == 0)
            {
                fRegister register = new fRegister();
                register.Show();
            }
        }
    }
}
