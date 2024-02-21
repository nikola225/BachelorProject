using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Rezervacija
{
    public class SODodajRezervaciju : SystemOperationBase
    {
        private readonly Rezervacija rezervacija;
        public bool Result { get; private set; }
        public Rezervacija rezervacijaZaDodavanje { get; private set; }
        public SODodajRezervaciju(Rezervacija r)
        {
            rezervacija = r;
        }
        protected override void Execute()
        {
            try
            {
                rezervacijaZaDodavanje = rezervacija;
                Result = true;
            }
            catch (Exception ex)
            {
                Result = false;
                Debug.WriteLine(">>>>>>>>> " + ex);
            }
        }
    }
}
