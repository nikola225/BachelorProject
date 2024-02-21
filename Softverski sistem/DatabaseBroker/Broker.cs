using Common;
using Common.Klase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Broker
    {
        SqlConnection connection;
        SqlTransaction transaction;
        public Broker() 
        {
            connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZavrsniRad;Integrated Security=True;Connect Timeout=30;");
        }
        public void Open()
        {
            connection.Open();
        }
        public void Close()
        {
            connection?.Close();
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }
        public void Commit()
        {
            transaction?.Commit();
        }
        public void RollBack()
        {
            transaction?.Rollback();
        }

        public void Registruj(object u)
        {
            throw new NotImplementedException();
        }

        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", connection, transaction);
        }
    }
}
