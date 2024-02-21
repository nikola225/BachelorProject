using Common.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_User
{
    public class SOVratiSveAdministratore : SystemOperationBase
    {
        BindingList<User> users = new BindingList<User>();
        private readonly User u = new User();
        public BindingList<User> Result { get; private set; }
        public SOVratiSveAdministratore(BindingList<User> users)
        {
            this.users = users;
        }
        protected override void Execute()
        {
            List<User> pomocna = new List<User>();
            pomocna = repository.GetAll(new User()).OfType<User>().ToList();
            Result = new BindingList<User>(pomocna);
        }
    }
}
