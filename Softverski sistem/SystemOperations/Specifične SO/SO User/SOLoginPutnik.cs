using Common.Domenske_Klase;
using Common.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO
{
    public class SOLoginPutnik : SystemOperationBase
    {
        List<Putnik> putnici = new List<Putnik>();
        private readonly Putnik p = new Putnik();
        public Putnik Result { get; private set; }
        public SOLoginPutnik(Putnik p)
        {
            this.p = p;
        }
        protected override void Execute()
        {
            putnici = repository.GetAll(new Putnik()).OfType<Putnik>().ToList();
            foreach (Putnik putnik in putnici)
            {
                if (p.Username == putnik.Username && p.Password == putnik.Password)
                {
                    Result = putnik;
                }
            }
        }
    }
}
