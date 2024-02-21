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
    public class SOObrisiPutnika : SystemOperationBase
    {
        private readonly Putnik putnik;
        public bool Result { get; private set; }
        public SOObrisiPutnika(Putnik p)
        {
            putnik = p;
        }
        protected override void Execute()
        {
            try
            {
                repository.Delete(putnik);
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
