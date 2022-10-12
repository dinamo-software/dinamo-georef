using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{

    [Migration(202203202155, "Load Pais Argentina")]
    public class _20220320_2155_LoadPais_Argentina : Migration
    {
        public override void Up()
        {
            var  sequence = new Helpers.SequenceHelper();
            
            Insert.IntoTable("pais")
                .Row(new { 
                    id = sequence.Next(), 
                    code = Constants.PaisesConstants.ArgentinaCode, 
                    name = "Argentina", 
                    iso_alfa_2 = "AR", 
                    iso_alfa_3 = "ARG" 
                });
        }

        public override void Down()
        {
            Delete.FromTable("pais").Row(new { code = Constants.PaisesConstants.ArgentinaCode });
        }
    }
}
