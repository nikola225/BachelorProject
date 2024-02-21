using Common.Domenske_Klase;
using Common.Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOSacuvajIzmeneAdmina : SystemOperationBase
    {
        private readonly User admin;
        public bool Result { get; private set; }
        public SOSacuvajIzmeneAdmina(User a)
        {
            admin = a;
        }
        protected override void Execute()
        {
            try
            {
                repository.Update(admin);
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
