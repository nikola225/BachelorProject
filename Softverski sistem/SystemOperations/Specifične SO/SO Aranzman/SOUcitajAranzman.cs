using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations.Specifične_SO.SO_Aranzman
{
    public class SOUcitajAranzman : SystemOperationBase
    {
        private readonly Aranzman aranzman = new Aranzman();
        public Aranzman Result { get; private set; }
        public SOUcitajAranzman(int IdAranzmana)
        {
            aranzman.Id = IdAranzmana;
        }
        protected override void Execute()
        {
            try
            {
                List<Aranzman> pomocna = repository.GetAll(new Aranzman()).OfType<Aranzman>().ToList();
                foreach(Aranzman a in pomocna)
                {
                    if(a.Id == aranzman.Id)
                    {
                        Result = a;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>> " + ex);
                Result = null;
            }
        }
    }
}
