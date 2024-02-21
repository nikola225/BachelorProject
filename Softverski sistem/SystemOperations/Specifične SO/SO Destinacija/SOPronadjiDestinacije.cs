using Common.Domenske_Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Destinacija
{
    public class SOPronadjiDestinacije : SystemOperationBase
    {
        BindingList<Destinacija> listaDestinacija = new BindingList<Destinacija>();
        string kriterijum;
        public BindingList<Destinacija> Result { get; private set; }
        public SOPronadjiDestinacije(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            List<Destinacija> pomocna = repository.GetAll(new Destinacija()).OfType<Destinacija>().ToList();
            foreach (Destinacija d in pomocna)
            {
                if (d.Naziv.Contains(kriterijum))
                {
                    listaDestinacija.Add(d);
                }
            }

            Result = listaDestinacija;
        }
    }
}
