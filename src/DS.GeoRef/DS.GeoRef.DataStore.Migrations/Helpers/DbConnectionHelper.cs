using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Linq;
using Microsoft.Data.SqlClient;

namespace DS.GeoRef.DataStore.Migrations.Helpers
{
    public class DbConnectionHelper
    {
        public DbConnection GetConnection(string connectionString)
        {
            var dbConnection = new SqlConnection(connectionString);
            return dbConnection;
        }
    }
}
