using Common.Domenske_Klase;
using Common.Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOVratiSveDestinacije : SystemOperationBase
    {
        BindingList<Destinacija> listaDestinacija = new BindingList<Destinacija>();
        public BindingList<Destinacija> Result { get; private set; }
        public SOVratiSveDestinacije(BindingList<Destinacija> listaDestinacija)
        {
            // Nije mi potrebno, proveriti
            this.listaDestinacija = listaDestinacija;
        }
        protected override void Execute()
        {
            List<Destinacija> pomocna = repository.GetAll(new Destinacija()).OfType<Destinacija>().ToList();
            Result = new BindingList<Destinacija>(pomocna);
        }
    }
}
