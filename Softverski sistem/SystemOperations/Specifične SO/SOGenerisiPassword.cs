using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOGenerisiPassword : SystemOperationBase
    {
        public string Result { get; private set; }
        int length;
        public SOGenerisiPassword(int length)
        {
            this.length = length;
        }
        protected override void Execute()
        {
            const string karakteri = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder noviPassword = new StringBuilder();
            Random random = new Random();
            while (length-- > 0)
            {
                noviPassword.Append(karakteri[random.Next(karakteri.Length)]);
            }
            
            Result = noviPassword.ToString();
        }
    }
}
