using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{

    /// <summary>
    /// Se utilizan los codigos de provincias de georef-ar
    /// </summary>
    /// <remarks>
    /// DATOS ARGENTINA
    /// https://github.com/datosgobar
    /// https://github.com/datosgobar/georef-ar-api
    /// GEOREF - AR: Se utilizan los codigos de provincias de georef-ar
    /// </remarks>
    [Migration(202203291850, "Create Table Gran LaPlata")]
    public class _20220329_1850_CreateTable_Glp : Migration
    {
        public override void Up()
        {
            Create.Table("glp")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_glp")
                .WithColumn("municipio_code").AsString(10).NotNullable().Unique()
                .WithColumn("zona_code").AsString(10).NotNullable()
                .WithColumn("cordon_code").AsString(10).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("glp");
        }
    }
}