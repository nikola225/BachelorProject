using Common.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Common.Domenske_Klase
{
    [Serializable]
    public class Destinacija : IDomainObject
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        
        public Destinacija Self { get {  return this; } }
        public override string ToString()
        {
            return Naziv;
        }
        public override bool Equals(object obj)
        {
            if (obj is Destinacija d)
            {
                return d.Id == Id;
            }
            return false;
        }

        [Browsable(false)]
        public string TableName => "Destinacija";

        #region INSERT
        [Browsable(false)]
        public string InsertValues => "@naziv";

        [Browsable(false)]
        public void Values(SqlCommand cmd, object obj)
        {
            Destinacija d = (Destinacija)obj;
            cmd.Parameters.AddWithValue("@naziv", (string)d.Naziv);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region JOIN
        [Browsable(false)]
        public List<string> JoinConditions => null;
        [Browsable(false)]
        public List<string> JoinTableNames => null;
        [Browsable(false)]
        public List<string> JoinColumnNames => null;
        #endregion

        #region UPDATE
        [Browsable(false)]
        public string UpdateSetStatement => "Naziv = @Naziv";
        
        [Browsable(false)]
        public string PrimaryKeyPropertyName => "Id";

        public object PrimaryKeyValue => Id;

        public void SetUpdateValues(SqlCommand command, IDomainObject obj)
        {
            Destinacija d = (Destinacija)obj;
            command.Parameters.AddWithValue("@Id", d.Id);
            command.Parameters.AddWithValue("@Naziv", d.Naziv);

            command.ExecuteNonQuery();
        }
        #endregion

        #region DELETE
        [Browsable(false)]
        public void SetDeleteParameters(SqlCommand command, IDomainObject domainObject)
        {
            Destinacija destinacija = (Destinacija)domainObject;
            command.Parameters.AddWithValue("@primaryKey", destinacija.Id);
        }

        [Browsable(false)]
        public string DeleteCondition => $"{PrimaryKeyPropertyName} = @primaryKey";
        #endregion

        #region SELECT
        [Browsable(false)]
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Destinacija d = new Destinacija()
            {
                Id = (int)reader["Id"],
                Naziv = (string)reader["Naziv"]
            };

            return d;
        } 
        #endregion
   
    }
}