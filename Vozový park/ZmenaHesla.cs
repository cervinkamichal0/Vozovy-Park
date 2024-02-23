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
    public partial class fZmenaHesla : Form
    {
        Databaze.Uzivatel upravenyUzivatel = new Databaze.Uzivatel();
        public fZmenaHesla()
        {
            InitializeComponent();
        }

        private void bZmenitHeslo_Click(object sender, EventArgs e)
        {
            if (tBNoveHeslo.Text != tBPotvrzeniNovehoHesla.Text)
            {
                lNoveHesloNesmiBytPrazdne.Visible = false;
                lChybnePuvodniHeslo.Visible = false;
                lNovaHeslaSeNeshoduji.Visible = true;
                lNovaHeslaSeNeshoduji.Visible = false;
                return;
            }
            if (tBPuvodniHeslo.Text.GetHashCode().ToString() != Databaze.dUzivatele[Databaze.prihlasenyUzivatel].heslo)
            {
                lNoveHesloNesmiBytPrazdne.Visible = false;
                lNovaHeslaSeNeshoduji.Visible = false;
                lChybnePuvodniHeslo.Visible = true;
                lNovaHeslaSeNeshoduji.Visible = false;
                return;
            }
            if (tBNoveHeslo.Text == "" || tBPotvrzeniNovehoHesla.Text == "")
            {
                lNoveHesloNesmiBytPrazdne.Visible = true;
                lChybnePuvodniHeslo.Visible = false;
                lNovaHeslaSeNeshoduji.Visible = false;
                lNovaHeslaSeNeshoduji.Visible = false;
                return;
            }
            if (tBPuvodniHeslo.Text == tBNoveHeslo.Text)
            {
                lNovaHeslaSeNeshoduji.Visible = false;
                lChybnePuvodniHeslo.Visible = false;
                lNoveHesloNesmiBytPrazdne.Visible = false;
                lNoveHesloNesmiBytStejneJakoPuvodni.Visible = true;
                return;
            }
                
            upravenyUzivatel.jmeno = Databaze.dUzivatele[Databaze.prihlasenyUzivatel].jmeno;
            upravenyUzivatel.prijmeni = Databaze.dUzivatele[Databaze.prihlasenyUzivatel].prijmeni;
            upravenyUzivatel.heslo = tBNoveHeslo.Text.GetHashCode().ToString();
            upravenyUzivatel.admin = Databaze.dUzivatele[Databaze.prihlasenyUzivatel].admin;
            upravenyUzivatel.aktivni = Databaze.dUzivatele[Databaze.prihlasenyUzivatel].aktivni;
            upravenyUzivatel.zmenaHesla = false;
            upravenyUzivatel.posledniPrihlaseni = Databaze.dUzivatele[Databaze.prihlasenyUzivatel].posledniPrihlaseni;
            Databaze.dUzivatele.Remove(Databaze.prihlasenyUzivatel);
            Databaze.dUzivatele.Add(Databaze.prihlasenyUzivatel, upravenyUzivatel);
            this.Close();
        }
    }
}
