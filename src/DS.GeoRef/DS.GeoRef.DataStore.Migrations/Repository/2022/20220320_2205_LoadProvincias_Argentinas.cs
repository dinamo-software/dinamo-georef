using Dapper;
using FluentMigrator;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{

    [Migration(202203202205, "Load Pais Argentina")]
    public class _20220320_2205_LoadProvincias_Argentinas : Migration
    {
        private Dictionary<string, dynamic> registroDePaises = new Dictionary<string, dynamic>();

        public override void Up()
        {
            LoadPaises(ConnectionString);

            var baseUrl = "https://apis.datos.gob.ar/georef/api";
            var segmentProvincias = "/provincias?campos=id,nombre";
            var provinciaDgaRepository = new Source.ARG.DGA.ProvinciaDgaRepository(baseUrl, segmentProvincias);
            var provincias = provinciaDgaRepository.All();

            var sequence = new Helpers.SequenceHelper();
            foreach (var p in provincias)
            {
                Insert
                    .IntoTable("provincia")
                    .Row(new
                    {
                        id = sequence.Next(),
                        code = p.id,
                        name = p.nombre,
                        pais_id = registroDePaises[Constants.PaisesConstants.ArgentinaCode].id
                    });
            }


        }

        public void LoadPaises(string connectionString)
        {
            var connection = new Helpers.DbConnectionHelper().GetConnection(connectionString);
            var paises = connection.Query<dynamic>("select id, code, name from pais");
            foreach (var p in paises)
            {
                registroDePaises.Add(p.code, p);
            }
        }

        public override void Down()
        {
            Delete.FromTable("provincia").Row(new { pais_id = Constants.PaisesConstants.ArgentinaCode });
        }
    }
}
