﻿using Dapper;
using FluentMigrator;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using DS.GeoRef.DataStore.Dapper;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{

    [Migration(202203202205, "Load Pais Argentina")]
    public class _20220320_2205_LoadProvincias_Argentinas : Migration
    {

        public override void Up()
        {
            


        }

        public void LoadPaises(string connectionString)
        {
        }

        public override void Down()
        {
            var countryRegistry = new CountryDapperRepository(ConnectionString);
            Delete.FromTable("provincia").Row(new { pais_id = countryRegistry.Get(Constants.PaisesConstants.ArgentinaCode).id });
        }
    }
}
