using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vozový_park
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            StreamReader nacteniUzivatelu = new StreamReader("uzivatele.txt");
            string radek;
            string[] rozdelenyRadek;
            Databaze.Uzivatel nactenyUzivatel = new Databaze.Uzivatel();
            while (!nacteniUzivatelu.EndOfStream)
            {
                radek = nacteniUzivatelu.ReadLine();
                rozdelenyRadek = radek.Split(';');
                nactenyUzivatel.jmeno = rozdelenyRadek[1];
                nactenyUzivatel.prijmeni = rozdelenyRadek[2];
                nactenyUzivatel.heslo = rozdelenyRadek[3];
                nactenyUzivatel.posledniPrihlaseni = DateTime.Parse(rozdelenyRadek[4]);
                nactenyUzivatel.admin = bool.Parse(rozdelenyRadek[5]);
                nactenyUzivatel.aktivni = bool.Parse(rozdelenyRadek[6]);
                nactenyUzivatel.zmenaHesla = bool.Parse(rozdelenyRadek[7]);
                Databaze._dUzivatele.Add(rozdelenyRadek[0], nactenyUzivatel);
            }
            nacteniUzivatelu.Close();


            StreamReader nacteniVozu = new StreamReader("vozy.txt");
            Databaze.Vuz nactenyVuz = new Databaze.Vuz();
            while (!nacteniVozu.EndOfStream)
            {
                radek = nacteniVozu.ReadLine();
                rozdelenyRadek = radek.Split(';');
                nactenyVuz.vyrobce = rozdelenyRadek[1];
                nactenyVuz.model = rozdelenyRadek[2];
                nactenyVuz.typ = rozdelenyRadek[3];
                nactenyVuz.spotreba = double.Parse(rozdelenyRadek[4]);
                nactenyVuz.aktivni = bool.Parse(rozdelenyRadek[5]);
                nactenyVuz.deaktivovanyOd = DateTime.Parse(rozdelenyRadek[6]);
                nactenyVuz.deaktivovanyDo = DateTime.Parse(rozdelenyRadek[7]);
                if (nactenyVuz.deaktivovanyDo <= DateTime.Now)
                    nactenyVuz.aktivni = true;
                Databaze._dVozy.Add(rozdelenyRadek[0], nactenyVuz);
            }
            nacteniVozu.Close();


            StreamReader nacteniServisniKnihy = new StreamReader("servisniKniha.txt");
            Databaze.ServisniKniha nactenyUkon = new Databaze.ServisniKniha();
            while(!nacteniServisniKnihy.EndOfStream)
            {
                radek = nacteniServisniKnihy.ReadLine();
                rozdelenyRadek = radek.Split(';');
                nactenyUkon.idVozu = rozdelenyRadek[0];
                nactenyUkon.ukon = rozdelenyRadek[1];
                nactenyUkon.cisloFaktury = int.Parse(rozdelenyRadek[2]);
                nactenyUkon.cena = decimal.Parse(rozdelenyRadek[3]);
                nactenyUkon.datumACasProvedeni = DateTime.Parse(rozdelenyRadek[4]);
                Databaze._dServisniKniha.Add(nactenyUkon);
            }
            nacteniServisniKnihy.Close();


            StreamReader nacteniRezervaci = new StreamReader("rezervace.txt");
            Databaze.Rezervace nactenaRezervace = new Databaze.Rezervace();
            while(!nacteniRezervaci.EndOfStream)
            {
                radek = nacteniRezervaci.ReadLine();
                rozdelenyRadek = radek.Split(';');
                nactenaRezervace.idVozu = rozdelenyRadek[0];
                nactenaRezervace.idUzivatele = rozdelenyRadek[1];
                nactenaRezervace.rezervaceOd = DateTime.Parse(rozdelenyRadek[2]);
                nactenaRezervace.rezervaceDo = DateTime.Parse(rozdelenyRadek[3]);
                nactenaRezervace.aktivni = bool.Parse(rozdelenyRadek[4]);
                Databaze._dRezervace.Add(nactenaRezervace);
            }
            nacteniRezervaci.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
        }
    }
    public class Databaze
    {
        public struct Uzivatel
        {
            public string jmeno;
            public string prijmeni;
            public string heslo;
            public DateTime posledniPrihlaseni;
            public bool admin;
            public bool aktivni;
            public bool zmenaHesla;
        }
        public struct Vuz
        {
            public string vyrobce;
            public string model;
            public string typ;
            public double spotreba;
            public bool aktivni;
            public DateTime deaktivovanyOd;
            public DateTime deaktivovanyDo;
        }
        public struct ServisniKniha
        {
            public string idVozu;
            public string ukon;
            public long cisloFaktury;
            public decimal cena;
            public DateTime datumACasProvedeni;
        }
        public struct Rezervace
        {
            public string idVozu;
            public string idUzivatele;
            public DateTime rezervaceOd;
            public DateTime rezervaceDo;
            public bool aktivni;
        }

        public static Dictionary<string, Databaze.Uzivatel> _dUzivatele = new Dictionary<string, Databaze.Uzivatel>();
        public static Dictionary<string, Databaze.Uzivatel> dUzivatele
        {
            get { return _dUzivatele; }
            set { _dUzivatele = value; }
        }


        public static Dictionary<string, Databaze.Vuz> _dVozy = new Dictionary<string, Databaze.Vuz>();

        public static Dictionary<string, Databaze.Vuz> dVozy
        {
            get { return _dVozy; }
            set { _dVozy = value; }
        }


        public static List<Databaze.ServisniKniha> _dServisniKniha = new List<Databaze.ServisniKniha>();
        public static List<Databaze.ServisniKniha> dServisniKniha
        {
            get { return _dServisniKniha; }
            set { _dServisniKniha = value; }
        }


        public static List<Databaze.Rezervace> _dRezervace = new List<Databaze.Rezervace>();
        public static List<Databaze.Rezervace> dRezervace
        {
            get { return _dRezervace; }
            set { _dRezervace = value; }
        }

        public static string _prihlasenyUzivatel;
        public static string prihlasenyUzivatel
        {
            get {return _prihlasenyUzivatel; }
            set { _prihlasenyUzivatel = value; }
        }

        public static string _idVozu;
        public static string idVozu
        {
            get { return _idVozu; }
            set { _idVozu = value; }
        }
    }
}
