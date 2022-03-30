using Dapper;
using DS.GeoRef.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class MunicipioAmbaDapperRepository
    {
        private Dictionary<string, MunicipioAmbaEntity> registroDeMunicipios = new Dictionary<string, MunicipioAmbaEntity>();
        private string connectionStringInternal;

        public MunicipioAmbaDapperRepository(string connectionString)
        {

            this.connectionStringInternal = connectionString;
            var connection = DbConnectionFactory.Create(connectionString);
            var municipios = connection.Query<MunicipioAmbaEntity>(@"select id, municipio_code, zona_code, cordon_code from amba");

            foreach (var m in municipios)
            {
                registroDeMunicipios.Add(m.municipio_code, m);
            }
        }

        public List<string> AllKeys()
        {
            return registroDeMunicipios.Keys.AsList();
        }

        public List<MunicipioAmbaEntity> All()
        {
            return registroDeMunicipios.Values.AsList();
        }

        public MunicipioAmbaEntity Get(string key)
        {
            return registroDeMunicipios[key];
        }
    }
}
