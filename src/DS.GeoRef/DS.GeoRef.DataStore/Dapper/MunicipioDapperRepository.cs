using Dapper;
using DS.GeoRef.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class MunicipioDapperRepository
    {
        private Dictionary<string, MunicipioEntity> registroDeMunicipios = new Dictionary<string, MunicipioEntity>();
        private string connectionStringInternal;

        public MunicipioDapperRepository(string connectionString)
        {
            this.connectionStringInternal = connectionString;
            var connection = DbConnectionFactory.Create(connectionString);
            var municipios = connection.Query<MunicipioEntity>("select id, code, name from municipio");
           
            foreach (var m in municipios)
            {
                registroDeMunicipios.Add(m.code, m);
            }
        }

        public List<string> AllKeys()
        {
            return registroDeMunicipios.Keys.AsList();
        }

        public List<MunicipioEntity> All()
        {
            return registroDeMunicipios.Values.AsList();
        }

        public List<string> AllAmbaKeys()
        {
            var connection = DbConnectionFactory.Create(this.connectionStringInternal);
            var amba = connection.Query<string>("select municipio_code from amba").AsList();
            return amba;
        }

        public List<string> AllGlpKeys()
        {
            var connection = DbConnectionFactory.Create(this.connectionStringInternal);
            var amba = connection.Query<string>("select municipio_code from glp").AsList();
            return amba;
        }

        public dynamic Get(string key)
        {
            return registroDeMunicipios[key];
        }
    }
}
