using Dapper;
using DS.GeoRef.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class ProvinciaDapperRepository
    {
        private Dictionary<string, StateEntity> registroDeProvincias = new Dictionary<string, StateEntity>();

        public ProvinciaDapperRepository(string connectionString)
        {
            var connection = DbConnectionFactory.Create(connectionString);
            var provincias = connection.Query<StateEntity>("select id, code, name from provincia");
            foreach (var p in provincias)
            {
                registroDeProvincias.Add(p.code, p);
            }
        }

        public List<string> AllKeys()
        {
            return registroDeProvincias.Keys.AsList();
        }

        public List<StateEntity> All()
        {
            return registroDeProvincias.Values.AsList();
        }

        public dynamic Get(string key)
        {
            return registroDeProvincias[key];
        }
    }
}
