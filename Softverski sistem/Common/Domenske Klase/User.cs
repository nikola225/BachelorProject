using Common.Domenske_Klase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Klase
{
    [Serializable]
    public class User : IDomainObject
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
        public string TableName => "Administrator";

        public string InsertValues => "@username, @password, @firstname, @lastname, @email";

        public List<string> JoinConditions => null;

        public List<string> JoinTableNames => null;

        public List<string> JoinColumnNames => null;

        #region UPDATE
        public void SetUpdateValues(SqlCommand command, IDomainObject obj)
        {
            User u = (User)obj;
            command.Parameters.AddWithValue("@Username", u.Username);
            command.Parameters.AddWithValue("@Password", u.Password);
            command.Parameters.AddWithValue("@Email", u.Email);
            command.Parameters.AddWithValue("@FirstName", u.FirstName);
            command.Parameters.AddWithValue("@LastName", u.LastName);

            command.ExecuteNonQuery();
        }
        public string PrimaryKeyPropertyName => "Username";

        public string UpdateSetStatement => "Username = @Username, Password = @Password, Email = @Email, FirstName = @FirstName, LastName = @LastName";

        public object PrimaryKeyValue => Username; 
        #endregion

        public string DeleteCondition => throw new NotImplementedException();

        public void Values(SqlCommand cmd, object obj)
        {
            User u = (User)obj;
            cmd.Parameters.AddWithValue("@username", (string)u.Username);
            cmd.Parameters.AddWithValue("@password", (string)u.Password);
            cmd.Parameters.AddWithValue("@firstname", (string)u.FirstName);
            cmd.Parameters.AddWithValue("@lastname", (string)u.LastName);
            cmd.Parameters.AddWithValue("@email", (string)u.Email);

            cmd.ExecuteNonQuery();
        }

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            User u = new User()
            {
                Username = (string)reader["Username"],
                Password = (string)reader["Password"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Email = (string)reader["Email"]
            };

            return u;
        }

        public void SetDeleteParameters(SqlCommand command, IDomainObject domainObject)
        {
            throw new NotImplementedException();
        }
    }
}
