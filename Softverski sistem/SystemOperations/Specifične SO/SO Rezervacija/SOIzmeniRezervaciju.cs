using Common.Domenske_Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Rezervacija
{
    public class SOIzmeniRezervaciju : SystemOperationBase
    {
        private readonly Rezervacija rezervacija;
        public bool Result { get; private set; }
        public SOIzmeniRezervaciju(Rezervacija r)
        {
            rezervacija = r;
        }
        protected override void Execute()
        {
            try
            {
                repository.Update(rezervacija);
                Result = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>> " + ex);
                Result = false;
            }
        }
    }
}
