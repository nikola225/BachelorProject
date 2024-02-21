using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations.Specifične_SO.SO_Destinacija;

namespace SystemOperations.Specifične_SO.SO_Rezervacija
{
    public class SOPronadjiRezervacije : SystemOperationBase
    {
        BindingList<Rezervacija> listaRezervacija = new BindingList<Rezervacija>();
        string kriterijum;
        public BindingList<Rezervacija> Result { get; private set; }
        public SOPronadjiRezervacije(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            List<Rezervacija> pomocna = repository.GetAll(new Rezervacija()).OfType<Rezervacija>().ToList();

            foreach (Rezervacija r in pomocna)
            { 

                if (r.Putnik.FirstName.Contains(kriterijum) ||
                    r.Putnik.LastName.Contains(kriterijum) ||
                    r.Aranzman.Destinacija.Naziv.Contains(kriterijum))
                {
                    listaRezervacija.Add(r);
                }
            }

            Result = listaRezervacija;
        }
    }
}
