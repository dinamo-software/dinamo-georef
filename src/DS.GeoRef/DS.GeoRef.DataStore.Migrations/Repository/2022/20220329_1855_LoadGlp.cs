using Dapper;
using FluentMigrator;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using DS.GeoRef.DataStore.Dapper;
using DS.GeoRef.DataStore.Migrations.Constants;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{

    [Migration(20220329_1855, "Load Municipios Gran LaPlata")]
    public class _20220329_1855_LoadGlp : Migration
    {
        public override void Up()
        {
            var sequence = new Helpers.SequenceHelper();
            
            Insert.IntoTable("glp").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.LaPlata,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("glp").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Berisso,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });
            
            Insert.IntoTable("glp").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Ensenada,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

        }

        public override void Down()
        {
            Delete.FromTable("glp").AllRows();
        }
    }
}
