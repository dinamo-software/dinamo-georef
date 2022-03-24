using Dapper;
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

    [Migration(202203241313, "Load Municipios Amba")]
    public class _20220324_1313_LoadAmba : Migration
    {
        public override void Up()
        {
          
            var provincias = new ProvinciaDapperRepository(ConnectionString);
            var sequence = new Helpers.SequenceHelper();
            foreach (var key in provincias.AllKeys())
            {
                var provincia = provincias.Get(key);
                var baseUrl = "https://apis.datos.gob.ar/georef/api";
                var segmentProvincias = $"/municipios" +
                    $"?interseccion=provincia:{provincia.code}" +
                    $"&campos=id,nombre" +
                    $"&max=200";

                var municipioDgaRepository = new Source.ARG.DGA.MunicipioDgaRepository(baseUrl, segmentProvincias);
                var municipios = municipioDgaRepository.All();
                foreach (var c in municipios)
                    //En esta parte me interesaria crear un IF donde compare todos los valores de c.id contra una lista con las constantes de MunicipiosContans
                {
                    Insert
                        .IntoTable("municipio")
                        .Row(new
                        {
                            id = sequence.Next(),
                            code = c.id,
                            name = c.nombre,
                            provincia_id = provincias.Get(provincia.code).id
                        });
                }
            }
        }

        public override void Down()
        {
            var provincias = new ProvinciaDapperRepository(ConnectionString);
            foreach (var key in provincias.AllKeys()) 
            {
                var provincia = provincias.Get(key);
                Delete.FromTable("municipio").Row(new { provincia_id = provincia.id });
            }
            
        }
    }
}
