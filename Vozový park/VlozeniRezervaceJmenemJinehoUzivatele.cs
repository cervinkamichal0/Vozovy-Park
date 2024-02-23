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
    public partial class fRezervaceJmenemUzivatele : Form
    {
        Databaze.Rezervace novarezervace = new Databaze.Rezervace();
        public fRezervaceJmenemUzivatele()
        {
            InitializeComponent();
        }

        private void bAPridatRezervaci_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                string vybrano = lBDostupneVozy.SelectedItem.ToString();
                string[] vybranoRozdeleno = vybrano.Split(',');
                string vybranyUzivatel = lBSeznamUzivatelu.SelectedItem.ToString();
                string[] vybranyUzivatelRozdeleny = vybranyUzivatel.Split(',');
                novarezervace.idUzivatele = vybranyUzivatelRozdeleny[0];
                novarezervace.idVozu = vybranoRozdeleno[0];
                novarezervace.rezervaceOd = dTRezervaceVozuOd.Value;
                novarezervace.rezervaceDo = dTRezervaceVozuDo.Value;
                novarezervace.aktivni = true;
                if (dTRezervaceVozuOd.Value >= dTRezervaceVozuDo.Value)
                {
                    lVTutoDobuJeVuzDeaktivovan.Visible = false;
                    lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
                    lMuisteVybratPolozkuZeSeznamu.Visible = false;
                    ldatumOdNesmiBytStarsiNezDatumDo.Visible = true;
                    return;
                }
                foreach (var v in Databaze.dRezervace.ToList())
                {
                    if (v.idVozu == vybranoRozdeleno[0] && v.rezervaceOd <= novarezervace.rezervaceDo && novarezervace.rezervaceOd <= v.rezervaceDo)
                    {
                        if (v.aktivni == false)
                        {
                            Databaze.dRezervace.Remove(v);
                            continue;
                        }
                        ldatumOdNesmiBytStarsiNezDatumDo.Visible = false;
                        lVTutoDobuJeVuzDeaktivovan.Visible = false;
                        lMuisteVybratPolozkuZeSeznamu.Visible = false;
                        lRezervaceSePrekryvaSJinouRezervaci.Visible = true;
                        return;
                    }
                }
                foreach (var v in Databaze.dVozy)
                {
                    if (v.Key == vybranoRozdeleno[0] && v.Value.aktivni == false && v.Value.deaktivovanyOd <= novarezervace.rezervaceDo && novarezervace.rezervaceOd <= v.Value.deaktivovanyDo)
                    {
                        ldatumOdNesmiBytStarsiNezDatumDo.Visible = false;
                        lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
                        lMuisteVybratPolozkuZeSeznamu.Visible = false;
                        lVTutoDobuJeVuzDeaktivovan.Visible = true;
                        return;
                    }
                    
                }
                Databaze._dRezervace.Add(novarezervace);
                this.Close();
            }
            catch(NullReferenceException)
            {
                ldatumOdNesmiBytStarsiNezDatumDo.Visible = false;
                lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
                lVTutoDobuJeVuzDeaktivovan.Visible = false;
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }
        }
        private void fRezervaceJmenemUzivatele_Load(object sender, EventArgs e)
        {
            dTRezervaceVozuOd.Value = DateTime.Now;
            dTRezervaceVozuDo.Value = DateTime.Now;
            dTRezervaceVozuOd.MinDate = DateTime.Now;
            dTRezervaceVozuDo.MinDate = DateTime.Now;


            foreach (var v in Databaze.dVozy)
            {
                lBDostupneVozy.Items.Add(v.Key + "," + v.Value.vyrobce + "," + v.Value.model);
            }
            foreach (var v in Databaze.dUzivatele)
            {
                if (v.Key == Databaze.prihlasenyUzivatel)
                {
                     lBSeznamUzivatelu.Items.Add(v.Key + "," + v.Value.jmeno + "," + v.Value.prijmeni + "," + "Admin: " + v.Value.admin + "," + "Aktivní: " + v.Value.aktivni + " (VY)");
                     continue;
                }
                 lBSeznamUzivatelu.Items.Add(v.Key + "," + v.Value.jmeno + "," + v.Value.prijmeni + "," + "Admin: " + v.Value.admin + "," + "Aktivní: " + v.Value.aktivni);
                 
            }
        }

        private void lBDostupneVozy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string s = lBDostupneVozy.SelectedItem.ToString();
            string[] rozdeleno = s.Split(',');
            Databaze._idVozu = rozdeleno[0];
            fInformaceOVozu informaceOVozu = new fInformaceOVozu();
            informaceOVozu.Show();
        }
    }
}
