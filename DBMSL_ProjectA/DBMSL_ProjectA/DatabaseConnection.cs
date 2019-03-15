using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace DBMSL_ProjectA
{
    class DatabaseConnection
    {
        static String connectionURL = "Data Source=MUSHI\\MUSHISQL;Initial Catalog=LabProjectA;Integrated Security=True; MultipleActiveResultSets=true";
                            
        public static SqlConnection connectionObject;
        static SqlCommand command;

        public DatabaseConnection()
        {

        }

        public static void setURL(string serverName, string dbName, string username, string password)
        {
            connectionURL = "Data Source = " + serverName + "; Initial Catalog = " + dbName + "; User ID = " + username + ";"
                    + " Password = " + password + "; MultipleActiveResultSets = True";
        }


        
        public static bool start()
        {

            connectionObject = new SqlConnection(connectionURL);
            try
            {
                connectionObject.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }


        }
        
        public static void createStatement(string query)
        {
            command = new SqlCommand(query);
            command.Connection = connectionObject;
        }


        public static SqlDataReader getData()
        {
            return command.ExecuteReader();
        }

        public static int performAction()
        {
            return command.ExecuteNonQuery();
        }

        public static int executeScalar()
        {
            return (int)command.ExecuteScalar();
        }

        public static void close()
        {
            if (connectionObject.State == ConnectionState.Open)
                connectionObject.Close();
        }

        public static SqlConnection getConnectionObj()
        {
            return connectionObject;
        }

    }
}
