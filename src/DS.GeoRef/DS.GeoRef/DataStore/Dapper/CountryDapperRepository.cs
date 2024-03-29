﻿using Dapper;
using DS.GeoRef.DataStore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Dapper
{
    public class CountryDapperRepository
    {
        private Dictionary<string, PaisEntity> registry = new Dictionary<string, PaisEntity>();

        public CountryDapperRepository(string connectionString)
        {
            var connection = DbConnectionFactory.Create(connectionString); //Genera conexion a la base de datos
            var paises = connection.Query<PaisEntity>("select id, code, name, iso_alfa_2 from pais").AsList(); //Realizo una consulta
            foreach (var p in paises)
            {
                registry.Add(p.code, p);
            }
        }

        public List<string> AllKeys()
        {
            return registry.Keys.AsList();
        }

        public List<PaisEntity> All()
        {
            return registry.Values.AsList();
        }
        public dynamic Get(string key)
        {
            return registry[key];
        }
    }
}
