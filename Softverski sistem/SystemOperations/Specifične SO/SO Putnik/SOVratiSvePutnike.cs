using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOVratiSvePutnike : SystemOperationBase
    {
        BindingList<Putnik> listaPutnika = new BindingList<Putnik>();
        public BindingList<Putnik> Result { get; private set; }
        public SOVratiSvePutnike(BindingList<Putnik> listaPutnika)
        {
            // Nije mi potrebno, proveriti
            this.listaPutnika = listaPutnika;
        }
        protected override void Execute()
        {
            List<Putnik> pomocna = repository.GetAll(new Putnik()).OfType<Putnik>().ToList();
            Result = new BindingList<Putnik>(pomocna);
        }
    }
}
