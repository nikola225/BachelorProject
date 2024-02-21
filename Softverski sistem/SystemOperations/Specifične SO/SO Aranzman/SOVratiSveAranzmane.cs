using Common.Domenske_Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOVratiSveAranzmane : SystemOperationBase
    {
        BindingList<Aranzman> listaAranzmana = new BindingList<Aranzman>();
        public BindingList<Aranzman> Result { get; private set; }
        public SOVratiSveAranzmane(BindingList<Aranzman> listaAranzmana)
        {
            // Nije mi potrebno, proveriti
            this.listaAranzmana = listaAranzmana;
        }
        protected override void Execute()
        {
            List<Aranzman> pomocna = repository.GetAll(new Aranzman()).OfType<Aranzman>().ToList();
            Result = new BindingList<Aranzman>(pomocna);
        }
    }
}
