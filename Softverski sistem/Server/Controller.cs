using Common.Domenske_Klase;
using Common.Klase;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using SystemOperations;
using SystemOperations.Specifične_SO;
using SystemOperations.Specifične_SO.SO_Aranzman;
using SystemOperations.Specifične_SO.SO_Destinacija;
using SystemOperations.Specifične_SO.SO_Rezervacija;
using SystemOperations.Specifične_SO.SO_User;

namespace Server
{
    public class Controller
    {
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }

        BindingList<Rezervacija> rezervacijeZaDodavanje = new BindingList<Rezervacija>();
        private Controller()
        {
            //repository = new GenericDbRepository();
        }
        public User LoginAdmin(User user)
        {
            SystemOperationBase so = new SOLoginAdmin(user);
            so.ExecuteTemplate();
            user = ((SOLoginAdmin)so).Result;
            return user;
        }
        public Putnik LoginPutnik(Putnik putnik)
        {
            SystemOperationBase so = new SOLoginPutnik(putnik);
            so.ExecuteTemplate();
            putnik = ((SOLoginPutnik)so).Result;
            return putnik;
        }
        public bool RegistracijaAdministratora(User user)
        {
            SystemOperationBase so = new SORegistracijaAdministratora(user);
            so.ExecuteTemplate();
            return ((SORegistracijaAdministratora)so).Result;
        }
        public bool RegistracijaPutnika(Putnik putnik)
        {
            SystemOperationBase so = new SORegistracijaPutnika(putnik);
            so.ExecuteTemplate();
            return ((SORegistracijaPutnika)so).Result;
        }
        public bool DodajDestinaciju(Destinacija destinacija)
        {
            SystemOperationBase so = new SODodajDestinaciju(destinacija);
            so.ExecuteTemplate();
            return ((SODodajDestinaciju)so).Result;
        }
        public BindingList<Destinacija> VratiSveDestinacije(BindingList<Destinacija> listaDestinacija)
        {
            SystemOperationBase so = new SOVratiSveDestinacije(listaDestinacija);
            so.ExecuteTemplate();
            listaDestinacija = ((SOVratiSveDestinacije)so).Result;
            return listaDestinacija;
        }
        public bool DodajAranzman(Aranzman aranzman)
        {
            SystemOperationBase so = new SODodajAranzman(aranzman);
            so.ExecuteTemplate();
            return ((SODodajAranzman)so).Result;
        }
        internal BindingList<Aranzman> VratiSveAranzmane(BindingList<Aranzman> listaAranzmana)
        {
            SystemOperationBase so = new SOVratiSveAranzmane(listaAranzmana);
            so.ExecuteTemplate();
            listaAranzmana = ((SOVratiSveAranzmane)so).Result;
            return listaAranzmana;
        }
        internal BindingList<Putnik> VratiSvePutnike(BindingList<Putnik> listaPutnika)
        {
            SystemOperationBase so = new SOVratiSvePutnike(listaPutnika);
            so.ExecuteTemplate();
            listaPutnika = ((SOVratiSvePutnike)so).Result;
            return listaPutnika;
        }
        internal bool SacuvajIzmenePutnika(Putnik putnik)
        {
            SystemOperationBase so = new SOSacuvajIzmenePutnika(putnik);
            so.ExecuteTemplate();
            return ((SOSacuvajIzmenePutnika)so).Result;
        }
        internal bool ObrisiPutnika(Putnik putnik)
        {
            SystemOperationBase so = new SOObrisiPutnika(putnik);
            so.ExecuteTemplate();
            return ((SOObrisiPutnika)so).Result;
        }
        internal BindingList<Putnik> PronadjiPutnike(string kriterijum)
        {
            SystemOperationBase so = new SOPronadjiPutnike(kriterijum);
            so.ExecuteTemplate();
            return ((SOPronadjiPutnike)so).Result;
        }
        internal bool SacuvajIzmeneDestinacije(Destinacija destinacija)
        {
            SystemOperationBase so = new SOSacuvajIzmeneDestinacije(destinacija);
            so.ExecuteTemplate();
            return ((SOSacuvajIzmeneDestinacije)so).Result;
        }
        internal bool ObrisiDestinaciju(Destinacija destinacija)
        {
            SystemOperationBase so = new SOObrisiDestinaciju(destinacija);
            so.ExecuteTemplate();
            return ((SOObrisiDestinaciju)so).Result;
        }
        internal bool SacuvajIzmeneAdmina(User admin)
        {
            SystemOperationBase so = new SOSacuvajIzmeneAdmina(admin);
            so.ExecuteTemplate();
            return ((SOSacuvajIzmeneAdmina)so).Result;
        }
        internal BindingList<Destinacija> PronadjiDestinacije(string kriterijum)
        {
            SystemOperationBase so = new SOPronadjiDestinacije(kriterijum);
            so.ExecuteTemplate();
            return ((SOPronadjiDestinacije)so).Result;
        }
        internal bool SacuvajIzmeneAranzmana(Aranzman aranzman)
        {
            SystemOperationBase so = new SOSacuvajIzmeneAranzmana(aranzman);
            so.ExecuteTemplate();
            return ((SOSacuvajIzmeneAranzmana)so).Result;
        }
        internal bool ObrisiAranzman(Aranzman aranzman)
        {
            SystemOperationBase so = new SOObrisiAranzman(aranzman);
            so.ExecuteTemplate();
            return ((SOObrisiAranzman)so).Result;
        }
        internal bool DodajRezervaciju(Rezervacija rezervacija)
        {
            SystemOperationBase so = new SODodajRezervaciju(rezervacija);
            so.ExecuteTemplate();
            rezervacijeZaDodavanje.Add(((SODodajRezervaciju)so).rezervacijaZaDodavanje);
            return ((SODodajRezervaciju)so).Result;
        }
        internal string GenerisiPassword(int length)
        {
            SystemOperationBase so = new SOGenerisiPassword(length);
            so.ExecuteTemplate();
            return ((SOGenerisiPassword)so).Result;
        }
        internal bool SendEmail(string toEmail, string newPassword)
        {
            SystemOperationBase so = new SOSendEmail(toEmail, newPassword);
            so.ExecuteTemplate();
            return ((SOSendEmail)so).Result;
        }
        internal BindingList<Rezervacija> VratiSveRezervacije(BindingList<Rezervacija> listaRezervacija)
        {
            SystemOperationBase so = new SOVratiSveRezervacije(listaRezervacija);
            so.ExecuteTemplate();
            listaRezervacija = ((SOVratiSveRezervacije)so).Result;
            return listaRezervacija;
        }

        internal Aranzman UcitajAranzman(int IdAranzmana)
        {
            Aranzman aranzman = new Aranzman();
            SystemOperationBase so = new SOUcitajAranzman(IdAranzmana);
            so.ExecuteTemplate();
            aranzman = ((SOUcitajAranzman)so).Result;
            return aranzman;
        }

        internal string UcitajDestinaciju(int IdDestinacije)
        {
            Destinacija destinacija = new Destinacija();
            SystemOperationBase so = new SOUcitajDestinaciju(IdDestinacije);
            so.ExecuteTemplate();
            destinacija = ((SOUcitajDestinaciju)so).Result;
            return destinacija.Naziv.ToString();
        }

        internal bool IzmeniRezervaciju(Rezervacija rezervacija)
        {
            SystemOperationBase so = new SOIzmeniRezervaciju(rezervacija);
            so.ExecuteTemplate();
            return ((SOIzmeniRezervaciju)so).Result;
        }

        internal bool ObrisiRezervaciju(Rezervacija rezervacija)
        {
            SystemOperationBase so = new SOObrisiRezervaciju(rezervacija);
            so.ExecuteTemplate();
            return ((SOObrisiRezervaciju)so).Result;
        }

        internal BindingList<Rezervacija> PronadjiRezervacije(string kriterijum)
        {
            SystemOperationBase so = new SOPronadjiRezervacije(kriterijum);
            so.ExecuteTemplate();
            return ((SOPronadjiRezervacije)so).Result;
        }

        internal bool ZapamtiRezervacije()
        {
            SystemOperationBase so = new SOZapamtiRezervacije(rezervacijeZaDodavanje);
            so.ExecuteTemplate();
            rezervacijeZaDodavanje.Clear();
            return ((SOZapamtiRezervacije)so).Result;
        }

        internal BindingList<User> VratiSveAdministratore(BindingList<User> listaAdministratora)
        {
            SystemOperationBase so = new SOVratiSveAdministratore(listaAdministratora);
            so.ExecuteTemplate();
            listaAdministratora = ((SOVratiSveAdministratore)so).Result;
            return listaAdministratora;
        }
    }
}