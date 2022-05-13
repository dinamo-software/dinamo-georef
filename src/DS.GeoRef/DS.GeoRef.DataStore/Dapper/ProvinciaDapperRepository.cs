using Dapper;
using DS.GeoRef.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class ProvinciaDapperRepository
    {
        private Dictionary<string, ProvinciaEntity> registroDeProvincias = new Dictionary<string, ProvinciaEntity>();

        public ProvinciaDapperRepository(string connectionString)
        {
            var connection = DbConnectionFactory.Create(connectionString);
            var provincias = connection.Query<ProvinciaEntity>("select id, code, name from provincia");
            foreach (var p in provincias)
            {
                registroDeProvincias.Add(p.code, p);
            }
        }

        public List<string> AllKeys()
        {
            return registroDeProvincias.Keys.AsList();
        }

        public List<ProvinciaEntity> All()
        {
            return registroDeProvincias.Values.AsList();
        }

        public dynamic Get(string key)
        {
            return registroDeProvincias[key];
        }
    }
}
