using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace PMS_Notes.DBConnection
{
    public class DBCon
    {
        public readonly static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PMSN;Integrated Security=True;Connect Timeout=30";
        public static SqlConnection GetDbConnection()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConnectionString;
            return sqlConnection;
        }
    }
}
