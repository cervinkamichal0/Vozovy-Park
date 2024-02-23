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
    public partial class fPridaniRezervace : Form
    {
        Databaze.Rezervace novarezervace = new Databaze.Rezervace();
        public fPridaniRezervace()
        {
            InitializeComponent();
        }

        private void bPridatRezervaci_Click(object sender, EventArgs e)
        {
            try
            {
                lMuisteVybratPolozkuZeSeznamu.Visible = false;
                string vybrano = lBDostupneVozy.SelectedItem.ToString();
                string[] vybranoRozdeleno = vybrano.Split(',');
                novarezervace.idUzivatele = Databaze.prihlasenyUzivatel;
                novarezervace.idVozu = vybranoRozdeleno[0];
                novarezervace.rezervaceOd = dTRezervaceVozuOd.Value;
                novarezervace.rezervaceDo = dTRezervaceVozuDo.Value;
                novarezervace.aktivni = true;
                if(dTRezervaceVozuOd.Value >= dTRezervaceVozuDo.Value)
                {
                    lMuisteVybratPolozkuZeSeznamu.Visible = false;
                    lVTutoDobuJeVuzDeaktivovan.Visible = false;
                    lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
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
                        lMuisteVybratPolozkuZeSeznamu.Visible = false;
                        lVTutoDobuJeVuzDeaktivovan.Visible = false;
                        lRezervaceSePrekryvaSJinouRezervaci.Visible = true;
                        return;
                    }
                }
                foreach(var v in Databaze.dVozy)
                {
                    if (v.Key == vybranoRozdeleno[0] && v.Value.aktivni == false && v.Value.deaktivovanyOd <= novarezervace.rezervaceDo && novarezervace.rezervaceOd <= v.Value.deaktivovanyDo)
                    {
                        lMuisteVybratPolozkuZeSeznamu.Visible = false;
                        lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
                        lVTutoDobuJeVuzDeaktivovan.Visible = true;
                        return;
                    }

                }
                Databaze._dRezervace.Add(novarezervace);
                this.Close();
            }
            catch (NullReferenceException)
            {
                lRezervaceSePrekryvaSJinouRezervaci.Visible = false;
                lVTutoDobuJeVuzDeaktivovan.Visible = false;
                lMuisteVybratPolozkuZeSeznamu.Visible = true;
            }

            
        }

        private void fPridaniRezervace_Load(object sender, EventArgs e)
        {
            foreach (var v in Databaze.dVozy)
            {
                lBDostupneVozy.Items.Add(v.Key + ","  + v.Value.vyrobce + "," + v.Value.model);
            }
            dTRezervaceVozuOd.Value = DateTime.Now;
            dTRezervaceVozuDo.Value = DateTime.Now;
            dTRezervaceVozuDo.MinDate = DateTime.Now;
            dTRezervaceVozuOd.MinDate = DateTime.Now;
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
