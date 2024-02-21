using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Aranzman
{
    public class SOSacuvajIzmeneAranzmana : SystemOperationBase
    {
        private readonly Aranzman aranzman;
        public bool Result { get; private set; }
        public SOSacuvajIzmeneAranzmana(Aranzman a)
        {
            aranzman = a;
        }
        protected override void Execute()
        {
            try
            {
                repository.Update(aranzman);
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
