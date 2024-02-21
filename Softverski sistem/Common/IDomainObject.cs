using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IDomainObject
    {
        // KORISTIM ZA SVE
        string TableName { get; }
        // KORISTIM ZA INSERT
        string InsertValues { get; }
        void Values(SqlCommand cmd, object obj);

        // KORISTIM ZA UPDATE
        string UpdateSetStatement { get; }
        string PrimaryKeyPropertyName { get; }
        object PrimaryKeyValue { get; }
        void SetUpdateValues(SqlCommand command, IDomainObject obj);

        // KORISTIM ZA DELETE
        string DeleteCondition { get; }
        void SetDeleteParameters(SqlCommand command, IDomainObject domainObject);

        // KORISTIM ZA JOIN
        List<string> JoinConditions { get; }
        List<string> JoinTableNames { get; }
        List<string> JoinColumnNames { get; }

        // KORISTIM ZA JOIN I SELECT
        IDomainObject ReadObjectRow(SqlDataReader reader);


    }
}
