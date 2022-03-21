using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class CountryDapperRepository
    {
        private Dictionary<string, dynamic> registry = new Dictionary<string, dynamic>();

        public CountryDapperRepository(string connectionString)
        {
            var connection = DbConnectionFactory.Create(connectionString);
            var provincias = connection.Query<dynamic>("select id, code, name from pais").AsList();
            foreach (var p in provincias)
            {
                registry.Add(p.code, p);
            }
        }

        public List<string> AllKeys()
        {
            return registry.Keys.AsList();
        }

        public dynamic Get(string key)
        {
            return registry[key];
        }
    }
}
