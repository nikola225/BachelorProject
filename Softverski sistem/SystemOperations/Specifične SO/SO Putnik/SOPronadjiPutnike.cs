using Common.Domenske_Klase;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations.Specifične_SO
{
    public class SOPronadjiPutnike : SystemOperationBase
    {
        BindingList<Putnik> listaPutnika = new BindingList<Putnik>();
        string kriterijum;
        public BindingList<Putnik> Result { get; private set; }
        public SOPronadjiPutnike(string kriterijum)
        {
            this.kriterijum = kriterijum;
        }
        protected override void Execute()
        {
            List<Putnik> pomocna = repository.GetAll(new Putnik()).OfType<Putnik>().ToList();
            
            foreach (Putnik p in pomocna)
            {
                if (p.FirstName.Contains(kriterijum) ||
                    p.LastName.Contains(kriterijum) ||
                    p.JMBG.Contains(kriterijum) ||
                    p.PassportNumber.Contains(kriterijum) ||
                    p.PhoneNumber.Contains(kriterijum) ||
                    p.Username.Contains(kriterijum))
                {
                    listaPutnika.Add(p);
                }
            }
            Result = listaPutnika;
        }
    }
}
