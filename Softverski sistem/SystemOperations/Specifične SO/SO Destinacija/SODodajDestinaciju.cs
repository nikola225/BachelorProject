using Common.Domenske_Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SODodajDestinaciju : SystemOperationBase
    {
        private readonly Destinacija destinacija;
        public bool Result { get; private set; }
        public SODodajDestinaciju(Destinacija d)
        {
            destinacija = d;
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(destinacija);
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
