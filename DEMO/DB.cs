using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO
{
    internal class DB
    {
        public string stringCon()
        {
            return   @"Data Source = DESKTOP-2MGBRF0;Initial Catalog=demo;Integrated Security=True";

        }
        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-2MGBRF0;Initial Catalog=demo;Integrated Security=True");

        public void oppenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }



    }
}
