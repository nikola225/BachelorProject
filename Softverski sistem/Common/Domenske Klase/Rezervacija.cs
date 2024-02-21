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
    public class Rezervacija : IDomainObject
    {
        public Aranzman Aranzman { get; set; }
        public Putnik Putnik { get; set; }
        public string Destinacija { get; set; }
        public int BrojRezervacije { get; set; }

        public string TableName => "Rezervacija";

        #region INSERT
        public string InsertValues => "@Aranzman, @Putnik, @BrojRezervacije";
        public void Values(SqlCommand cmd, object obj)
        {
            Rezervacija r = (Rezervacija)obj;
            cmd.Parameters.AddWithValue("@Aranzman", r.Aranzman.Id);
            cmd.Parameters.AddWithValue("@Putnik", r.Putnik.Username);
            cmd.Parameters.AddWithValue("@BrojRezervacije", r.BrojRezervacije);

            cmd.ExecuteNonQuery();
        }

        #endregion
        #region UPDATE
        public string UpdateSetStatement => "BrojRezervacije = @BrojRezervacije, Aranzman = @aranzman, Putnik = @putnik";

        public string PrimaryKeyPropertyName => "BrojRezervacije";

        public object PrimaryKeyValue => BrojRezervacije;

        public void SetUpdateValues(SqlCommand command, IDomainObject obj)
        {
            Rezervacija r = (Rezervacija)obj;

            command.Parameters.AddWithValue("@BrojRezervacije", r.BrojRezervacije);
            command.Parameters.AddWithValue("@aranzman", r.Aranzman.Id);
            command.Parameters.AddWithValue("@putnik", r.Putnik.Username);

            command.ExecuteNonQuery();
        } 
        #endregion
        #region JOIN
        public List<string> JoinConditions => new List<string>()
        {
            "Rezervacija.Aranzman = Aranzman.Id",
            "Rezervacija.Putnik = Putnik.Username",
            "Aranzman.Destinacija = Destinacija.Id"
        };

        public List<string> JoinTableNames => new List<string>()
        {
            "Aranzman",
            "Putnik",
            "Destinacija"
        };
        List<string> IDomainObject.JoinColumnNames => null;
        #endregion
        #region SELECT
        [Browsable(false)]
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Rezervacija r = new Rezervacija()
            {
                BrojRezervacije = (int)reader["BrojRezervacije"],
                Aranzman = new Aranzman
                {
                    Id = (int)reader["Id"],
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
                },
                Putnik = new Putnik
                {
                    Username = (string)reader["Username"],
                    Password = (string)reader["Password"],
                    FirstName = (string)reader["FirstName"],
                    LastName = (string)reader["LastName"],
                    Email = (string)reader["Email"],
                    PhoneNumber = (string)reader["PhoneNumber"],
                    PassportNumber = (string)reader["PassportNumber"],
                    JMBG = (string)reader["JMBG"]
                },
            };

            return r;
        }
        #endregion
        #region DELETE
        public void SetDeleteParameters(SqlCommand command, IDomainObject domainObject)
        {
            Rezervacija rezervacija = (Rezervacija)domainObject;
            command.Parameters.AddWithValue("@primaryKey", rezervacija.BrojRezervacije);
        }
        public string DeleteCondition => $"{PrimaryKeyPropertyName} = @primaryKey";
        #endregion

    }
}
