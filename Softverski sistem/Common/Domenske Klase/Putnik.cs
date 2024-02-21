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
    public class Putnik : IDomainObject
    {
        public string Username { get; set; }       
        [Browsable(false)]
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PassportNumber { get; set; }
        public string JMBG { get; set; }
        public override bool Equals(object obj)
        {
            if(obj is Putnik p)
            {
                return p.Username == Username;
            }
            return false;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        [Browsable(false)]
        public string TableName => "Putnik";

        #region INSERT
        [Browsable(false)]
        public string InsertValues => "@username, @password, @firstname, @lastname, @email, @phonenumber, @passportnumber, @jmbg";
        public void Values(SqlCommand cmd, object obj)
        {
            Putnik p = (Putnik)obj;
            cmd.Parameters.AddWithValue("@username", (string)p.Username);
            cmd.Parameters.AddWithValue("@password", (string)p.Password);
            cmd.Parameters.AddWithValue("@firstname", (string)p.FirstName);
            cmd.Parameters.AddWithValue("@lastname", (string)p.LastName);
            cmd.Parameters.AddWithValue("@email", (string)p.Email);
            cmd.Parameters.AddWithValue("@phonenumber", (string)p.PhoneNumber);
            cmd.Parameters.AddWithValue("@passportnumber", (string)p.PassportNumber);
            cmd.Parameters.AddWithValue("@jmbg", (string)p.JMBG);

            cmd.ExecuteNonQuery();
        }
        #endregion

        #region JOIN
        public List<string> JoinConditions => null;
        public List<string> JoinTableNames => null;
        public List<string> JoinColumnNames => null;
        #endregion

        #region UPDATE
        [Browsable(false)]
        public string UpdateSetStatement => "Username = @Username, Password = @Password, Email = @Email, FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, PassportNumber = @PassportNumber, JMBG = @JMBG";

        [Browsable(false)]
        public string PrimaryKeyPropertyName => "Username";

        [Browsable(false)]
        public object PrimaryKeyValue => Username;
        public void SetUpdateValues(SqlCommand command, IDomainObject obj)
        {
            Putnik p = (Putnik)obj;

            command.Parameters.AddWithValue("@Username", p.Username);
            command.Parameters.AddWithValue("@Password", p.Password);
            command.Parameters.AddWithValue("@Email", p.Email);
            command.Parameters.AddWithValue("@FirstName", p.FirstName);
            command.Parameters.AddWithValue("@LastName", p.LastName);
            command.Parameters.AddWithValue("@PhoneNumber", p.PhoneNumber);
            command.Parameters.AddWithValue("@PassportNumber", p.PassportNumber);
            command.Parameters.AddWithValue("@JMBG", p.JMBG);

            command.ExecuteNonQuery();
        }
        #endregion

        #region DELETE
        public string DeleteCondition => $"{PrimaryKeyPropertyName} = @primaryKey";

        public void SetDeleteParameters(SqlCommand command, IDomainObject domainObject)
        {
            Putnik putnik = (Putnik)domainObject;
            command.Parameters.AddWithValue("@primaryKey", putnik.Username);
        }
        #endregion

        #region SELECT
        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Putnik p = new Putnik()
            {
                Username = (string)reader["Username"],
                Password = (string)reader["Password"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Email = (string)reader["Email"],
                PhoneNumber = (string)reader["PhoneNumber"],
                PassportNumber = (string)reader["PassportNumber"],
                JMBG = (string)reader["JMBG"]
            };

            return p;
        } 
        #endregion

    }
}
