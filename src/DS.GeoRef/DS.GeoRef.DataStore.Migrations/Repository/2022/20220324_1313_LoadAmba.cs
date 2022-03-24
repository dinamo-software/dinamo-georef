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

    [Migration(202203241313, "Load Municipios Amba")]
    public class _20220324_1313_LoadAmba : Migration
    {
        public override void Up()
        {
            var sequence = new Helpers.SequenceHelper();
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), code = MunicipiosConstants.AlmiranteBrown });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), code = MunicipiosConstants.Avellaneda });
        }

        public override void Down()
        {
            Delete.FromTable("amba").AllRows();
        }
    }
}
