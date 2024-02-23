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

    public partial class fInformaceOVozu : Form
    {
        public fInformaceOVozu()
        {
            InitializeComponent();
        }

        private void fInformaceOVozu_Load(object sender, EventArgs e)
        {
            lId.Text = Databaze.idVozu;
            lVyrobce.Text = Databaze.dVozy[Databaze.idVozu].vyrobce;
            lModel.Text = Databaze.dVozy[Databaze.idVozu].model;
            lTyp.Text = Databaze.dVozy[Databaze.idVozu].typ;
            lSpotreba.Text = (Databaze.dVozy[Databaze.idVozu].spotreba.ToString() + " l/100km");
            foreach (var v in Databaze.dServisniKniha)
            {
                if (v.idVozu == Databaze.idVozu)
                    lBServisniUkony.Items.Add(v.ukon + ", " + v.cena.ToString() + " Kč, " + "č. faktury: " + v.cisloFaktury + ", " + v.datumACasProvedeni.Day + "." + v.datumACasProvedeni.Month + " " + v.datumACasProvedeni.Year);
            }
        }
    }
}
