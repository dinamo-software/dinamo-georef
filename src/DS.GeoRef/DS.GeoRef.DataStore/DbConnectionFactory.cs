using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DS.GeoRef.DataStore
{
    public class DbConnectionFactory
    {
        public static SqlConnection Create(string connectionString)
        {
            var dbConnection = new SqlConnection(connectionString);
            return dbConnection;

        }
    }
}
