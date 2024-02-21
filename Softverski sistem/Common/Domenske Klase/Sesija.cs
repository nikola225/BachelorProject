using Common.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domenske_Klase
{
    public class Sesija
    {
        private static Sesija instance;
        public User PrijavljeniUser { get; set; }
        public Putnik PrijavljeniPutnik { get; set; }
        private Sesija() { }
        public static Sesija Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Sesija();
                }
                return instance;
            }
        }

    }
}
