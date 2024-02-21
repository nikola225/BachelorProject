using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations.Specifične_SO.SO_Rezervacija
{
    public class SOZapamtiRezervacije : SystemOperationBase
    {
        private readonly BindingList<Rezervacija> listaRezervacija;
        public bool Result { get; private set; }
        public SOZapamtiRezervacije(BindingList<Rezervacija> rezervacije)
        {
            listaRezervacija = rezervacije;
        }
       
		protected override void Execute()
        {

            if (listaRezervacija.Count > 0)
            {
                foreach (Rezervacija r in listaRezervacija)
                {
                    try
                    {
                        repository.Add(r);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(">>>>>>>>> " + ex);
                        Result = false;
                        return;
                    }
                }

                Result = true; 
            }
            else
            {
                Result = false;
            }     
        }

    }
}
