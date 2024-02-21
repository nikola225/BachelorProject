using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Rezervacija
{
    public class SOVratiSveRezervacije : SystemOperationBase
    {
        BindingList<Rezervacija> listaRezervacija = new BindingList<Rezervacija>();
        public BindingList<Rezervacija> Result { get; private set; }
        public SOVratiSveRezervacije(BindingList<Rezervacija> listaRezervacija)
        {
            this.listaRezervacija = listaRezervacija;
        }
        protected override void Execute()
        {
            List<Rezervacija> pomocna = repository.GetAll(new Rezervacija()).OfType<Rezervacija>().ToList();
            Result = new BindingList<Rezervacija>(pomocna);
        }
    }
}
