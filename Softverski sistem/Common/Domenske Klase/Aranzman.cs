using Common.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domenske_Klase
{
    [Serializable]
    public class Aranzman : IDomainObject
    {
        public int Id { get; set; }
        public User Administrator { get; set; }
        public Destinacija Destinacija { get; set; }
        public string Opis { get; set; }
        public double Cena { get; set; }
        public int Kapacitet { get; set; }
        public TipPrevoza TipPrevoza { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public override string ToString()
        {
            return Id.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Aranzman a)
            {
                return a.Id == Id;
            }
            return false;
        }

        [Browsable(false)]
        public string TableName => "Aranzman";

        #region JOIN
        public List<string> JoinConditions => new List<string>()
        {
            "Aranzman.Administrator = Administrator.Username",
            "Aranzman.Destinacija = Destinacija.Id"
        };

        public List<string> JoinTableNames => new List<string>()
        {
            "Administrator",
            "Destinacija"
        };
        List<string> IDomainObject.JoinColumnNames => null;
        #endregion

        #region UPDATE
        public string PrimaryKeyPropertyName => "Id";

        [Browsable(false)]
        public string UpdateSetStatement => "Id = @Id, Administrator = @administrator, Destinacija = @destinacija, Opis = @opis, Cena = @cena, Kapacitet = @kapacitet, TipPrevoza = @tipPrevoza, DatumOd = @datumOd, DatumDo = @datumDo";

        [Browsable(false)]
        public object PrimaryKeyValue => Id;
        public void SetUpdateValues(SqlCommand command, IDomainObject obj)
        {
            Aranzman a = (Aranzman)obj;
            
            command.Parameters.AddWithValue("@Id", a.Id);
            command.Parameters.AddWithValue("@administrator", a.Administrator.Username);
            command.Parameters.AddWithValue("@destinacija", a.Destinacija.Id);
            command.Parameters.AddWithValue("@opis", a.Opis);
            command.Parameters.AddWithValue("@cena", a.Cena);
            command.Parameters.AddWithValue("@kapacitet", a.Kapacitet);
            command.Parameters.AddWithValue("@tipPrevoza", a.TipPrevoza);
            command.Parameters.AddWithValue("@datumOd", a.DatumOd);
            command.Parameters.AddWithValue("@datumDo", a.DatumDo);

            command.ExecuteNonQuery();
        }
        #endregion

        #region INSERT
        [Browsable(false)]
        public string InsertValues => "@id, @administrator, @destinacija, @opis, @cena, @kapacitet, @tipPrevoza, @datumOd, @datumDo";

        [Browsable(false)]
        public void Values(SqlCommand cmd, object obj)
        {
            Aranzman a = (Aranzman)obj;
            cmd.Parameters.AddWithValue("@id", a.Id);
            cmd.Parameters.AddWithValue("@administrator", a.Administrator.Username);
            cmd.Parameters.AddWithValue("@destinacija", a.Destinacija.Id);
            cmd.Parameters.AddWithValue("@opis", a.Opis);
            cmd.Parameters.AddWithValue("@cena", a.Cena);
            cmd.Parameters.AddWithValue("@kapacitet", a.Kapacitet);
            cmd.Parameters.AddWithValue("@tipPrevoza", a.TipPrevoza);
            cmd.Parameters.AddWithValue("@datumOd", a.DatumOd);
            cmd.Parameters.AddWithValue("@datumDo", a.DatumDo);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region SELECT
        [Browsable(false)]
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Aranzman a = new Aranzman()
            {
                Id = (int)reader["Id"],
                Administrator = new User
                {
                    Username = (string)reader["Administrator"],
                },
                Destinacija = new Destinacija
                {
                    Id = (int)reader["Destinacija"],
                    Naziv = (string)reader["Naziv"]
                },
                Opis = (string)reader["Opis"],
                Cena = (double)reader["Cena"],
                Kapacitet = (int)reader["Kapacitet"],
                TipPrevoza = (TipPrevoza)reader["TipPrevoza"],
                DatumOd = (DateTime)reader["DatumOd"],
                DatumDo = (DateTime)reader["DatumDo"]
            };

            return a;
        }
        #endregion

        #region DELETE
        public void SetDeleteParameters(SqlCommand command, IDomainObject domainObject)
        {
            Aranzman aranzman = (Aranzman)domainObject;
            command.Parameters.AddWithValue("@primaryKey", aranzman.Id);
        }
        public string DeleteCondition => $"{PrimaryKeyPropertyName} = @primaryKey"; 
        #endregion
    }
}
