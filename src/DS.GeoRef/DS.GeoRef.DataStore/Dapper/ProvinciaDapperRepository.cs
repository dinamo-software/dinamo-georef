using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class ProvinciaDapperRepository
    {
        private Dictionary<string, dynamic> registroDeProvincias = new Dictionary<string, dynamic>();

        public ProvinciaDapperRepository(string connectionString)
        {
            var connection = DbConnectionFactory.Create(connectionString);
            var provincias = connection.Query<dynamic>("select id, code, name from provincia");
            foreach (var p in provincias)
            {
                registroDeProvincias.Add(p.code, p);
            }
        }

        public List<string> AllKeys()
        {
            return registroDeProvincias.Keys.AsList();
        }

        public dynamic Get(string key)
        {
            return registroDeProvincias[key];
        }
    }
}
