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
    public partial class fPridatVuz : Form
    {
        Databaze.Vuz novyVuz = new Databaze.Vuz();
        Databaze.ServisniKniha zapis = new Databaze.ServisniKniha();
        List<Databaze.ServisniKniha> zapisy = new List<Databaze.ServisniKniha>();
        fAlert alert = new fAlert();
        public fPridatVuz()
        {
            InitializeComponent();
        }

        private void bPridatVuz_Click(object sender, EventArgs e)
        {
            if (tBIdVozu.Text == "" || tBAVyrboce.Text == "" || tBAModel.Text == "" || tBASpotreba.Text == "" || tBATyp.Text == "")
            {
                lIdVozuJeJizZabrane.Visible = false;
                lSpotrebaMusiBytCislo.Visible = false;
                lMusiteVyplnitVsechnaPole.Visible = true;
                return;
            }
            foreach (var v in Databaze.dVozy)
            {
                if (tBIdVozu.Text == v.Key)
                {
                    lSpotrebaMusiBytCislo.Visible = false;
                    lMusiteVyplnitVsechnaPole.Visible = false;
                    lIdVozuJeJizZabrane.Visible = true;
                    return;
                }
            }
            if (double.TryParse(tBASpotreba.Text, out novyVuz.spotreba) == false)
            {
                lIdVozuJeJizZabrane.Visible = false;
                lMusiteVyplnitVsechnaPole.Visible = false;
                lSpotrebaMusiBytCislo.Visible = true;
                return;
            }

            novyVuz.vyrobce = tBAVyrboce.Text;
            novyVuz.model = tBAModel.Text;
            novyVuz.typ = tBATyp.Text;
            novyVuz.aktivni = true;
            Databaze._dVozy.Add(tBIdVozu.Text, novyVuz);
            foreach (var v in zapisy)
            {
                zapis.ukon = v.ukon;
                zapis.cena = v.cena;
                zapis.cisloFaktury = v.cisloFaktury;
                zapis.idVozu = tBIdVozu.Text;
                zapis.datumACasProvedeni = dtADatumACasProvedeni.Value;
                Databaze._dServisniKniha.Add(zapis);
            }
            
            this.Close();
        }

        private void bPridatServisniUkon_Click(object sender, EventArgs e)
        {
            decimal cena;
            long cisloFaktury;
            if (tBUkon.Text == "" || tBCena.Text == "" || tBCisloFaktuy.ToString() == "")
            {
                lCenaMusiBytCislo.Visible = false;
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = false;
                lVsechnaPoleMusiBytVyplnena.Visible = true;
                return;
            }
            if (long.TryParse(tBCisloFaktuy.Text, out cisloFaktury) == false)
            {
                lCenaMusiBytCislo.Visible = false;
                lVsechnaPoleMusiBytVyplnena.Visible = false;
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = true;
                return;
            }
          
            if (decimal.TryParse(tBCena.Text, out cena) == false)
            {
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = false;
                lVsechnaPoleMusiBytVyplnena.Visible = false;
                lCenaMusiBytCislo.Visible = true;
                return;
            }
            zapis.ukon = tBUkon.Text;
            zapis.cena = cena;
            zapis.cisloFaktury = cisloFaktury;
            zapisy.Add(zapis);
            lBServisniUkony.Items.Add(tBUkon.Text +", " + cena.ToString() + " Kč, " +"č. faktury: " + cisloFaktury + ", " + dtADatumACasProvedeni.Value.Day + "." + dtADatumACasProvedeni.Value.Month + " " + dtADatumACasProvedeni.Value.Year);

        }

        private void bOdstranitUkon_Click(object sender, EventArgs e)
        {
            try
            {
                lBServisniUkony.SelectedItem.ToString();
                alert.ShowDialog();
                if (fAlert.potvrzeni == true)
                {
                    lBServisniUkony.Items.RemoveAt(lBServisniUkony.SelectedIndex);
                    zapisy.RemoveAt(lBServisniUkony.SelectedIndex);
                }
            }
            catch(NullReferenceException) { }
            catch (ArgumentOutOfRangeException) { }

        }

        private void fPridatVuz_Load(object sender, EventArgs e)
        {
            dtADatumACasProvedeni.Value = DateTime.Now;
        }
    }
       

}
