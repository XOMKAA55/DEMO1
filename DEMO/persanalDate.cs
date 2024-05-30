using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DEMO
{
    internal class persanalDate
    {
        public static int idUser { get; private set; }
        public static string login { get; private set; }
        public static string Passwoed { get; private set; }
        public static string roles { get; private set; }

        public bool SetPersonalData(string login, string password)
        {
            var db = new DB();

            string sqlExpression = "SELECT TOP 1 * FROM Accs WHERE login = @login AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(db.stringCon()))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    command.Parameters.AddWithValue("@login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            idUser = (int)reader["id_users"];
                            roles = reader["roles"].ToString();
                            login = reader["login"].ToString();
                            Passwoed = reader["Password"].ToString();
                            return true;
                        }
                    }
                    return false;
                }

            }
        }
    }
}
