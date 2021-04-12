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
    public partial class fAdminMenu : Form
    {
        fAlert alert = new fAlert();
        Databaze.Uzivatel upravenyUzivatel = new Databaze.Uzivatel();
        string s;
        string[] rozdeleno;
        public fAdminMenu()
        {
            InitializeComponent();
        }

        private void bZmenaHesla_Click(object sender, EventArgs e)
        {
            fZmenaHesla fZmenaHesla = new fZmenaHesla();
            fZmenaHesla.Show();
        }

        private void bPridatUzivatele_Click(object sender, EventArgs e)
        {
            fRegister fRegister = new fRegister();
            fRegister.Show();
        }

        private void bVlozitRezervaciJmenemUzivatele_Click(object sender, EventArgs e)
        {
            fRezervaceJmenemUzivatele fRezervaceJmenemUzivatele = new fRezervaceJmenemUzivatele();
            fRezervaceJmenemUzivatele.Show();
        }

        private void bVynutitZměnuHesla_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                s = lBSeznamUzivatelu.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                upravenyUzivatel.jmeno = Databaze.dUzivatele[rozdeleno[0]].jmeno;
                upravenyUzivatel.prijmeni = Databaze.dUzivatele[rozdeleno[0]].prijmeni;
                upravenyUzivatel.heslo = Databaze.dUzivatele[rozdeleno[0]].heslo;
                upravenyUzivatel.aktivni = Databaze.dUzivatele[rozdeleno[0]].aktivni;
                upravenyUzivatel.admin = Databaze.dUzivatele[rozdeleno[0]].admin;
                upravenyUzivatel.posledniPrihlaseni = Databaze.dUzivatele[rozdeleno[0]].posledniPrihlaseni;
                upravenyUzivatel.zmenaHesla = true;
                Databaze.dUzivatele.Remove(rozdeleno[0]);
                Databaze.dUzivatele.Add(rozdeleno[0], upravenyUzivatel);
                lBSeznamUzivatelu.Items.Clear();
                Refresh();
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }

        private void bPridatVuz_Click(object sender, EventArgs e)
        {
            fPridatVuz fPridatVuz = new fPridatVuz();
            fPridatVuz.Show();
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
        private void fAdminMenu_FormClosing(object sender, FormClosingEventArgs e)
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
                    zapisUzivatelu.WriteLine(v.Key + ";" + v.Value.jmeno + ";" + v.Value.prijmeni + ";" + v.Value.heslo + ";" + v.Value.posledniPrihlaseni + ";" + v.Value.admin + ";" + v.Value.aktivni + ";" + v.Value.zmenaHesla);
            }
            zapisUzivatelu.Close();


            StreamWriter zapisVozu = new StreamWriter("vozy.txt");
            foreach (var v in Databaze.dVozy)
            {
                zapisVozu.WriteLine(v.Key + ";" + v.Value.vyrobce + ";" +v.Value.model +";"+ v.Value.typ+ ";" + v.Value.spotreba.ToString() + ";" + v.Value.aktivni + ";" + v.Value.deaktivovanyOd + ";" +v.Value.deaktivovanyDo);  
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

        private void fAdminMenu_Load(object sender, EventArgs e)
        {

            lUzivatelskeJmeno.Text = Databaze.prihlasenyUzivatel;
            lPosledniPrihlaseni.Text = ("Naposledy přihlášen: " + Databaze.dUzivatele[Databaze.prihlasenyUzivatel].posledniPrihlaseni.ToString());
            Refresh();
        }

        private void lBSeznamUzivatelu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lBSeznamUzivatelu.SelectedItem != null)
            {

                lBRezervaceUzivatele.Items.Clear();
                s = lBSeznamUzivatelu.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                int i = 0;
                foreach (var v in Databaze.dRezervace)
                {
                    if (v.idUzivatele == rozdeleno[0])
                        lBRezervaceUzivatele.Items.Add(i + "," +v.idVozu + "," + "Od: " + v.rezervaceOd + "," + "Do: " + v.rezervaceDo + ",Aktivní: " + v.aktivni);
                    i++;
                }
            }
        }
        private void lBSeznamVozu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            s = lBSeznamVozu.SelectedItem.ToString();
            rozdeleno = s.Split(',');
            Databaze._idVozu = rozdeleno[0];
            fUpraVozu upravaVozu = new fUpraVozu();
            upravaVozu.Show();
        }

        private void bOdstraitVuz_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                s = lBSeznamVozu.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                alert.ShowDialog();
                if (fAlert.potvrzeni == true)
                {
                    lBSeznamVozu.Items.Remove(lBSeznamVozu.SelectedItem);

                    foreach (var v in Databaze.dServisniKniha.ToList())
                    {
                        if (v.idVozu == rozdeleno[0])
                            Databaze.dServisniKniha.Remove(v);
                    }
                    foreach (var v in Databaze.dRezervace.ToList())
                    {
                        if (v.idVozu == rozdeleno[0])
                            Databaze.dRezervace.Remove(v);
                    }

                    Databaze.dVozy.Remove(rozdeleno[0]);
                }
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }
        private void bObnovit_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void bSmazatUzivatele_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                s = lBSeznamUzivatelu.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                alert.ShowDialog();
                if (fAlert.potvrzeni == true)
                {
                    if (rozdeleno[0] == Databaze.prihlasenyUzivatel)
                    {
                        lMuisteVybratPolozkuZeSeznamu.Visible = false;
                        lNemuzeteDeaktivovatSebe.Visible = false;
                        lNemuzeteOdstranitSebe.Visible = true;
                    }
                    else
                    {
                        foreach (var v in Databaze.dRezervace.ToList())
                        {
                            if (v.idUzivatele == rozdeleno[0])
                                Databaze.dRezervace.Remove(v);
                        }

                        lBSeznamUzivatelu.Items.Remove(lBSeznamUzivatelu.SelectedItem);
                        lBRezervaceUzivatele.Items.Clear();
                        Databaze.dUzivatele.Remove(rozdeleno[0]);
                    }
                }
                
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }

        private void bDeaktivovatUzivatele_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                s = lBSeznamUzivatelu.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                if (rozdeleno[0] == Databaze.prihlasenyUzivatel)
                {
                    lNemuzeteOdstranitSebe.Visible = false;
                    lNemuzeteDeaktivovatSebe.Visible = true;
                    return;
                }
                Databaze.Uzivatel upravenyUzivatel = new Databaze.Uzivatel();
                upravenyUzivatel.jmeno = Databaze.dUzivatele[rozdeleno[0]].jmeno;
                upravenyUzivatel.prijmeni = Databaze.dUzivatele[rozdeleno[0]].prijmeni;
                upravenyUzivatel.heslo = Databaze.dUzivatele[rozdeleno[0]].heslo;
                upravenyUzivatel.aktivni = false;
                upravenyUzivatel.admin = Databaze.dUzivatele[rozdeleno[0]].admin;
                upravenyUzivatel.posledniPrihlaseni = Databaze.dUzivatele[rozdeleno[0]].posledniPrihlaseni;
                Databaze.dUzivatele.Remove(rozdeleno[0]);
                Databaze._dUzivatele.Add(rozdeleno[0], upravenyUzivatel);

                Databaze.Rezervace upravenaRezervace = new Databaze.Rezervace();
                foreach (var v in Databaze.dRezervace.ToList())
                {
                    if (v.idUzivatele == rozdeleno[0])
                    {
                        upravenaRezervace.idUzivatele = v.idUzivatele;
                        upravenaRezervace.idVozu = v.idVozu;
                        upravenaRezervace.rezervaceOd = v.rezervaceOd;
                        upravenaRezervace.rezervaceDo = v.rezervaceDo;
                        upravenaRezervace.aktivni = false;
                        Databaze.dRezervace.Remove(v);
                        Databaze.dRezervace.Add(upravenaRezervace);
                    }
                }
                Refresh();
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }

        private void bAktivovatUzivatele_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                s = lBSeznamUzivatelu.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                Databaze.Uzivatel upravenyUzivatel = new Databaze.Uzivatel();
                upravenyUzivatel.jmeno = Databaze.dUzivatele[rozdeleno[0]].jmeno;
                upravenyUzivatel.prijmeni = Databaze.dUzivatele[rozdeleno[0]].prijmeni;
                upravenyUzivatel.heslo = Databaze.dUzivatele[rozdeleno[0]].heslo;
                upravenyUzivatel.aktivni = true;
                upravenyUzivatel.admin = Databaze.dUzivatele[rozdeleno[0]].admin;
                upravenyUzivatel.posledniPrihlaseni = Databaze.dUzivatele[rozdeleno[0]].posledniPrihlaseni;
                Databaze.dUzivatele.Remove(rozdeleno[0]);
                Databaze._dUzivatele.Add(rozdeleno[0], upravenyUzivatel);

                Databaze.Rezervace upravenaRezervace = new Databaze.Rezervace();
                foreach (var v in Databaze.dRezervace.ToList())
                {
                    if (v.idUzivatele == rozdeleno[0])
                    {
                        upravenaRezervace.idUzivatele = v.idUzivatele;
                        upravenaRezervace.idVozu = v.idVozu;
                        upravenaRezervace.rezervaceOd = v.rezervaceOd;
                        upravenaRezervace.rezervaceDo = v.rezervaceDo;
                        upravenaRezervace.aktivni = true;
                        Databaze.dRezervace.Remove(v);
                        Databaze.dRezervace.Add(upravenaRezervace);
                    }
                }
                Refresh();
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }

        private void bOdstranitRezervaci_Click(object sender, EventArgs e)
        {
            try
            {
                s = lBRezervaceUzivatele.SelectedItem.ToString();
                rozdeleno = s.Split(',');
                alert.ShowDialog();
                if (fAlert.potvrzeni == true)
                {
                    lBRezervaceUzivatele.Items.RemoveAt(lBRezervaceUzivatele.SelectedIndex);
                    Databaze.dRezervace.RemoveAt(int.Parse(rozdeleno[0]));
                }
            }
            catch(NullReferenceException)
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }
        public void Refresh()
        {
            lBSeznamUzivatelu.Items.Clear();
            lBSeznamVozu.Items.Clear();
            lBRezervaceUzivatele.Items.Clear();
            foreach (var v in Databaze.dUzivatele)
            {
                if (v.Key == Databaze.prihlasenyUzivatel)
                {
                    lBSeznamUzivatelu.Items.Add(v.Key + "," + v.Value.jmeno + "," + v.Value.prijmeni + "," + "Admin: " + v.Value.admin + "," + "Aktivní: " + v.Value.aktivni + ",Změna hesla: " + v.Value.zmenaHesla.ToString() + " (VY)");
                    continue;
                }
                lBSeznamUzivatelu.Items.Add(v.Key + "," + v.Value.jmeno + "," + v.Value.prijmeni + "," + "Admin: " + v.Value.admin + "," + "Aktivní: " + v.Value.aktivni + ",Změna hesla: " + v.Value.zmenaHesla.ToString());
            }
            foreach (var v in Databaze.dVozy)
            {
                lBSeznamVozu.Items.Add(v.Key + "," + v.Value.vyrobce + "," + v.Value.model);
            }
        }

    }

}
