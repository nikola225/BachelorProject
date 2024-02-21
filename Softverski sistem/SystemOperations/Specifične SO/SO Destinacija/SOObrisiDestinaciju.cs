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
    public class SOObrisiDestinaciju : SystemOperationBase
    {
        private readonly Destinacija destinacija;
        public bool Result { get; private set; }
        public SOObrisiDestinaciju(Destinacija d)
        {
            destinacija = d;
        }
        protected override void Execute()
        {
            try
            {
                repository.Delete(destinacija);
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
