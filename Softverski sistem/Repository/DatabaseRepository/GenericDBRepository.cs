using Common;
using Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Repository.DatabaseRepository
{
    public class GenericDBRepository : IRepository<IDomainObject>
    {
        private Broker broker = new Broker();
        public void Open()
        {
            broker.Open();
        }
        public void Close()
        {
            broker?.Close();
        }
        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }
        public void Commit()
        {
            broker?.Commit();
        }
        public void Rollback()
        {
            broker?.RollBack();
        }
        public void Add(IDomainObject domainObject)
        {
            SqlCommand command = broker.CreateCommand();
            command.CommandText = $"INSERT INTO {domainObject.TableName} VALUES ({domainObject.InsertValues})";
            domainObject.Values(command, domainObject);
        }
        public List<IDomainObject> GetAll(IDomainObject domainObject)
        {
            List<IDomainObject> result = new List<IDomainObject>();
            SqlCommand command = broker.CreateCommand();

            StringBuilder query = new StringBuilder($"SELECT * FROM {domainObject.TableName}");

            if (domainObject.JoinTableNames != null && domainObject.JoinConditions != null &&
                domainObject.JoinTableNames.Count > 0 && domainObject.JoinTableNames.Count == domainObject.JoinConditions.Count)
            {
                for (int i = 0; i < domainObject.JoinTableNames.Count; i++)
                {
                    query.Append($" JOIN {domainObject.JoinTableNames[i]} ON {domainObject.JoinConditions[i]}");
                }
            }

            command.CommandText = query.ToString();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IDomainObject rowObject = domainObject.ReadObjectRow(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }
        public void Delete(IDomainObject domainObject)
        {
            using (SqlCommand command = broker.CreateCommand())
            {
                command.CommandText = $"DELETE FROM {domainObject.TableName} WHERE {domainObject.DeleteCondition}";
                domainObject.SetDeleteParameters(command, domainObject);
                command.ExecuteNonQuery();
            }
        }
        public void Update(IDomainObject domainObject)
        {
            using (SqlCommand command = broker.CreateCommand())
            {
                command.CommandText = $"UPDATE {domainObject.TableName} SET {domainObject.UpdateSetStatement} WHERE {domainObject.PrimaryKeyPropertyName} = @primaryKey";
                command.Parameters.AddWithValue("@primaryKey", domainObject.PrimaryKeyValue);
                domainObject.SetUpdateValues(command, domainObject);
            }
        }
        public List<IDomainObject> Find(string kriterijum)
        {
            throw new NotImplementedException();
        }
    }
}
