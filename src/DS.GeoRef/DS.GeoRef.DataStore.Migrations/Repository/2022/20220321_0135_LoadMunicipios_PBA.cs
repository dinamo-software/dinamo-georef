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

    [Migration(202203210135, "Load Municipios PBA")]
    public class _20220321_0135_LoadMunicipios_PBA : Migration
    {
        private Dictionary<string, dynamic> registroDeProvincias = new Dictionary<string, dynamic>();

        public override void Up()
        {
            LoadProvincias(ConnectionString);

            var PBA = Constants.ProvinciasConstants.PBA;
            var baseUrl = "https://apis.datos.gob.ar/georef/api";
            var segmentProvincias = $"/municipios?interseccion=provincia:{PBA}&campos=id,nombre&max=135";
            var municipioDgaRepository = new Source.ARG.DGA.MunicipioDgaRepository(baseUrl, segmentProvincias);
            var comunas = municipioDgaRepository.All();

            var sequence = new Helpers.SequenceHelper();
            foreach (var c in comunas)
            {
                Insert
                    .IntoTable("municipio")
                    .Row(new
                    {
                        id = sequence.Next(),
                        code = c.id,
                        name = c.nombre,
                        provincia_id = registroDeProvincias[PBA].id
                    });
            }


        }

        public void LoadProvincias(string connectionString)
        {
            var connection = new Helpers.DbConnectionHelper().GetConnection(connectionString);
            var paises = connection.Query<dynamic>("select id, code, name from provincia");
            foreach (var p in paises)
            {
                registroDeProvincias.Add(p.code, p);
            }
        }

        public override void Down()
        {
            Delete.FromTable("municipio").Row(new { provincia_id = Constants.ProvinciasConstants.PBA });
        }
    }
}
