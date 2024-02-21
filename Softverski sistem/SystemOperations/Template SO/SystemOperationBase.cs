using Common;
using Repository;
using Repository.DatabaseRepository;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IRepository<IDomainObject> repository = new GenericDBRepository();
        public void ExecuteTemplate()
        {
            try
            {
                repository.Open();
                repository.BeginTransaction();
                Execute();
                repository.Commit();
            }
            catch(Exception ex)
            {
                repository.Rollback();
                MessageBox.Show("Greška! Više detalja >>> " + ex.Message);
            }
            finally
            {
                repository.Close();
            }
        } 

        protected abstract void Execute();
    }
}
