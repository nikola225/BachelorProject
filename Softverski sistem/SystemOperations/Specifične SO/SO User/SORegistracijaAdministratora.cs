using Common.Klase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations
{
    public class SORegistracijaAdministratora : SystemOperationBase
    {
        private readonly User user;
        public bool Result { get; private set; }
        public SORegistracijaAdministratora(User u)
        {
            user = u;
        }
        protected override void Execute()
        {
            try
            {
                repository.Add(user);
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
