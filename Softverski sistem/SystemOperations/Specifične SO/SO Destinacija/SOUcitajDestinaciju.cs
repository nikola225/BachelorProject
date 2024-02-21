using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Destinacija
{
    public class SOUcitajDestinaciju : SystemOperationBase
    {
        private Destinacija destinacija = new Destinacija();
        public Destinacija Result { get; private set; }
        public SOUcitajDestinaciju(int IdDestinacije)
        {
            destinacija.Id = IdDestinacije;
        }
        protected override void Execute()
        {
            try
            {
                List<Destinacija> pomocna = repository.GetAll(new Destinacija()).OfType<Destinacija>().ToList();
                foreach (Destinacija d in pomocna)
                {
                    if (d.Id == destinacija.Id)
                    {
                        Result = d;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>> " + ex);
                Result = null;
            }
        }
    }
}
