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
    public partial class fZapisDoServisniKnihy : Form
    {
        Databaze.ServisniKniha novyZapis = new Databaze.ServisniKniha();
        public fZapisDoServisniKnihy()
        {
            InitializeComponent();
        }

        private void bPridatZapis_Click(object sender, EventArgs e)
        {
            if (long.TryParse(tBCisloFaktuy.Text, out novyZapis.cisloFaktury) == false)
            {
                lCisloFakturyNesmíObsahovatJinoZnakyNezCisla.Visible = true;
                return;
            }
            if(decimal.TryParse(tBCena.Text, out novyZapis.cena) == false)
            {
                lCenaMusiBytCislo.Visible = true;
                return;
            }
            //PridatVuz.lBServisniUkony.Items.Add(tBUkon.Text +" " + novyZapis.cena + "Kč " +"Č. faktury: " + novyZapis.cisloFaktury);
            this.Close();
        }


    }
}
