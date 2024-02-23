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
    public partial class fUpraVozu : Form
    {
        fAlert alert = new fAlert();
        Databaze.ServisniKniha zapis = new Databaze.ServisniKniha();
        List<Databaze.ServisniKniha> zapisy = new List<Databaze.ServisniKniha>();
        Databaze.Vuz upravenyVuz = new Databaze.Vuz();
        List<Databaze.ServisniKniha> zaloha = new List<Databaze.ServisniKniha>();
        public fUpraVozu()
        {
            InitializeComponent();
        }

        private void fUpraVozu_Load(object sender, EventArgs e)
        {
            
            tBAVyrboce.Text = Databaze.dVozy[Databaze.idVozu].vyrobce;
            tBAModel.Text = Databaze.dVozy[Databaze.idVozu].model;
            tBATyp.Text = Databaze.dVozy[Databaze.idVozu].typ;
            tBASpotreba.Text = Databaze.dVozy[Databaze.idVozu].spotreba.ToString();
            upravenyVuz.deaktivovanyOd = Databaze.dVozy[Databaze.idVozu].deaktivovanyOd;
            upravenyVuz.deaktivovanyDo = Databaze.dVozy[Databaze.idVozu].deaktivovanyDo;

            dtADatumACasProvedeni.Value = DateTime.Now;
            lid.Text = Databaze.idVozu;

            foreach (var v in Databaze.dServisniKniha)
            {
                if (v.idVozu == Databaze.idVozu)
                {
                    lBServisniUkony.Items.Add(v.ukon + ", " + v.cena.ToString() + " Kč, " + "č. faktury: " + v.cisloFaktury + ", " + v.datumACasProvedeni.Day + "." + v.datumACasProvedeni.Month + " " + v.datumACasProvedeni.Year);
                    zapisy.Add(v);
                }
            }
            upravenyVuz.aktivni = Databaze.dVozy[Databaze.idVozu].aktivni;
            if (upravenyVuz.aktivni == true)
            {
                lAktivni.Text = "Aktivní";
                lAktivni.ForeColor = Color.YellowGreen;
                dTDeaktivaceOd.Value = DateTime.Now;
                dTDeaktivaceDo.Value = DateTime.Now;
            }
            else
            {
                if (Databaze.dVozy[Databaze.idVozu].deaktivovanyOd > DateTime.Now)
                {
                    lAktivni.Text = "Bude Deaktiovaný";
                    lAktivni.ForeColor = Color.Orange;
                }
                else
                {
                    lAktivni.Text = "Deaktivovaný";
                    lAktivni.ForeColor = Color.DarkRed;
                }

                dTDeaktivaceOd.Value = Databaze.dVozy[Databaze.idVozu].deaktivovanyOd;
                dTDeaktivaceDo.Value = Databaze.dVozy[Databaze.idVozu].deaktivovanyDo;
            }
        }

        private void bUlozit_Click(object sender, EventArgs e)
        {
            if (tBAModel.Text == "" || tBAVyrboce.Text =="" || tBATyp.Text =="" || tBASpotreba.Text =="")
            {

                lSpotrebaMusiBytCislo.Visible = false;
                lMusiteVyplnitVsechnaPole.Visible = true;
                return;
            }
            if (double.TryParse(tBASpotreba.Text, out upravenyVuz.spotreba) == false)
            {
                lMusiteVyplnitVsechnaPole.Visible = false;
                lSpotrebaMusiBytCislo.Visible = true;
                return;
            }
            upravenyVuz.vyrobce =tBAVyrboce.Text;
            upravenyVuz.model = tBAModel.Text;
            upravenyVuz.typ = tBATyp.Text;
            Databaze.dVozy.Remove(Databaze.idVozu);
            Databaze._dVozy.Add(Databaze.idVozu, upravenyVuz);

            foreach(var v in zapisy)
            {
                Databaze._dServisniKniha.Add(v);
            }
            Databaze._dServisniKniha = Databaze.dServisniKniha.Distinct().ToList();
            zapisy.Clear();
            this.Close();
        }

        private void bAktivovat_Click(object sender, EventArgs e)
        {
            upravenyVuz.aktivni = true;
            lAktivni.Text = "Aktivní";
            lAktivni.ForeColor = Color.YellowGreen;
        }

        private void bDeaktivovat_Click(object sender, EventArgs e)
        {
            if (dTDeaktivaceOd.Value > dTDeaktivaceDo.Value)
            {
                lDatumOdNesmiBytStarsiNezDnesniDatum.Visible = false;
                lDatumDoMusíBýtPozdějiNežOd.Visible = true;
                return;
            }
            if(dTDeaktivaceOd.Value < DateTime.Now.Date)
            {
                lDatumOdNesmiBytStarsiNezDnesniDatum.Visible = true;
                return;
            }
            else
            {
                lDatumOdNesmiBytStarsiNezDnesniDatum.Visible = false;
                lDatumDoMusíBýtPozdějiNežOd.Visible = false;
                upravenyVuz.deaktivovanyOd = dTDeaktivaceOd.Value;
                upravenyVuz.deaktivovanyDo = dTDeaktivaceDo.Value;
                upravenyVuz.aktivni = false;
                if (dTDeaktivaceOd.Value > DateTime.Now)
                {
                    lAktivni.Text = "Bude deaktiovaný";
                    lAktivni.ForeColor = Color.Orange;
                }
                else
                {
                    lAktivni.Text = "Deaktivovaný";
                    lAktivni.ForeColor = Color.DarkRed;
                }

            }
        }

        private void bPridatServisniUkon_Click(object sender, EventArgs e)
        {
            decimal cena;
            long cisloFaktury;
            if(tBUkon.Text == "" || tBCena.Text == "" || tBCisloFaktuy.ToString() == "")
            {
                lCenaMusiBytCislo.Visible = false;
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = false;
                lVsechnaPoleMusiBytVyplnena.Visible = true;
                return;
            }
            if (long.TryParse(tBCisloFaktuy.Text, out cisloFaktury) == false)
            {
                lVsechnaPoleMusiBytVyplnena.Visible = false;
                lCenaMusiBytCislo.Visible = false;
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = true;
                return;
            }

            if (decimal.TryParse(tBCena.Text, out cena) == false)
            {
                lVsechnaPoleMusiBytVyplnena.Visible = false;
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = false;
                lCenaMusiBytCislo.Visible = true;
                return;
            }
            zapis.ukon = tBUkon.Text;
            zapis.cena = cena;
            zapis.cisloFaktury = cisloFaktury;
            zapis.idVozu = Databaze.idVozu;
            zapis.datumACasProvedeni = dtADatumACasProvedeni.Value;
            zapisy.Add(zapis);
            lBServisniUkony.Items.Add(tBUkon.Text + ", " + cena.ToString() + " Kč, " + "č. faktury: " + cisloFaktury + ", " + dtADatumACasProvedeni.Value.Day + "." + dtADatumACasProvedeni.Value.Month + " " + dtADatumACasProvedeni.Value.Year);

        }

        private void bOdstranitUkon_Click(object sender, EventArgs e)
        {
            try
            {
                lBServisniUkony.SelectedItem.ToString();
                alert.ShowDialog();
                if (fAlert.potvrzeni == true)
                {
                    Databaze.dServisniKniha.Remove(zapisy.ElementAt(lBServisniUkony.SelectedIndex));
                    zapisy.RemoveAt(lBServisniUkony.SelectedIndex);
                    lBServisniUkony.Items.RemoveAt(lBServisniUkony.SelectedIndex);
                }
            }
            catch(NullReferenceException) { }
            catch (ArgumentOutOfRangeException) { }
        }
    }
}
