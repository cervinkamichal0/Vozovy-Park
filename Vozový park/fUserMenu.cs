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
    public partial class fUserMenu : Form
    {
        fAlert alert = new fAlert();
        Databaze.Uzivatel upravenyUzivatel = new Databaze.Uzivatel();
        public fUserMenu()
        {
            InitializeComponent();
        }

        private void bZmenaHesla_Click(object sender, EventArgs e)
        {
            fZmenaHesla zmenaHesla = new fZmenaHesla();
            zmenaHesla.Show();
        }

        private void bPridatRezervaci_Click(object sender, EventArgs e)
        {
            fPridaniRezervace fPridaniRezervace = new fPridaniRezervace();
            fPridaniRezervace.Show();
        }

        private void bOdhlasitSe_Click(object sender, EventArgs e)
        {
            upravenyUzivatel.jmeno = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].jmeno;
            upravenyUzivatel.prijmeni = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].prijmeni;
            upravenyUzivatel.heslo = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].heslo;
            upravenyUzivatel.aktivni = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].aktivni;
            upravenyUzivatel.admin = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].admin;
            upravenyUzivatel.posledniPrihlaseni = DateTime.Now;
            Databaze.dUzivatele.Remove(Databaze._prihlasenyUzivatel);
            Databaze._dUzivatele.Add(Databaze._prihlasenyUzivatel, upravenyUzivatel);
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.Show();
        }


        private void fUserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            upravenyUzivatel.jmeno = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].jmeno;
            upravenyUzivatel.prijmeni = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].prijmeni;
            upravenyUzivatel.heslo = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].heslo;
            upravenyUzivatel.aktivni = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].aktivni;
            upravenyUzivatel.admin = Databaze.dUzivatele[Databaze._prihlasenyUzivatel].admin;
            upravenyUzivatel.posledniPrihlaseni = DateTime.Now;
            Databaze.dUzivatele.Remove(Databaze._prihlasenyUzivatel);
            Databaze._dUzivatele.Add(Databaze._prihlasenyUzivatel, upravenyUzivatel);


            StreamWriter zapisUzivatelu = new StreamWriter("uzivatele.txt");
            foreach (var v in Databaze.dUzivatele)
            {
                zapisUzivatelu.WriteLine(v.Key + ";" + v.Value.jmeno + ";" + v.Value.prijmeni + ";" + v.Value.heslo + ";" + v.Value.posledniPrihlaseni + ";" + v.Value.admin + ";" + v.Value.aktivni + ";" +  v.Value.zmenaHesla);
            }
            zapisUzivatelu.Close();


            StreamWriter zapisRezervaci = new StreamWriter("rezervace.txt");
            foreach (var v in Databaze.dRezervace)
            {
                zapisRezervaci.WriteLine(v.idVozu + ";" + v.idUzivatele + ";" + v.rezervaceOd + ";" + v.rezervaceDo + ";" + v.aktivni);
            }
            zapisRezervaci.Close();

            Application.Exit();
        }

        private void fUserMenu_Load(object sender, EventArgs e)
        {
            lUzivatelskeJmeno.Text = Databaze.prihlasenyUzivatel;
            lPosledniPrihlaseni.Text = ("Naposledy přihlášen: " + Databaze.dUzivatele[Databaze.prihlasenyUzivatel].posledniPrihlaseni.ToString());
            Refresh();
        }

        private void bObnovit_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void bOdstranitRezervaci_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                string s = lBPrehledRezervaci.SelectedItem.ToString();
                string[] rozdeleno = s.Split(',');
                alert.ShowDialog();
                if (fAlert.potvrzeni == true)
                {
                    Databaze.dRezervace.RemoveAt(int.Parse(rozdeleno[0]));
                    lBPrehledRezervaci.Items.RemoveAt(lBPrehledRezervaci.SelectedIndex);
                }
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }
        public void Refresh()
        {
            lBPrehledRezervaci.Items.Clear();
            int i = 0;
            foreach (var v in Databaze.dRezervace)
            {
                
                if (v.idUzivatele == Databaze.prihlasenyUzivatel)
                    lBPrehledRezervaci.Items.Add(i+ "," + v.idVozu + "," + "Od: " + v.rezervaceOd + "," + "Do: " + v.rezervaceDo);
                i++;
            }
        }
    }
}
