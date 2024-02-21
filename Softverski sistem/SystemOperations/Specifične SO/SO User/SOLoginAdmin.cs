using Common.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations
{
    public class SOLoginAdmin : SystemOperationBase
    {
        List<User> users = new List<User>();
        private readonly User u = new User();
        public User Result { get; private set; }
        public SOLoginAdmin(User u) 
        {
            this.u = u;
        }
        protected override void Execute()
        {
            users = repository.GetAll(new User()).OfType<User>().ToList();
            foreach (User user in users)
            { 
                if (u.Username == user.Username && u.Password == user.Password)
                {
                    Result = user;
                }
            }
        }

        
    }
}
