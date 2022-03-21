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
    [Migration(202203202020, "Create Table Localidad")]
    public class _20220320_2020_CreateTable_Localidad : Migration
    {
        public override void Up()
        {

            Create.Table("localidad")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_localidad")
                .WithColumn("code").AsString(10).NotNullable().Unique() //GeoRefAr Code
                .WithColumn("name").AsString(100).NotNullable()
                .WithColumn("desc").AsString(500).Nullable()
                .WithColumn("municipio_id").AsInt32().NotNullable().ForeignKey("FK_localidad_municipio", "municipio", "id");
        }

        public override void Down()
        {
            Delete.Table("localidad");
        }
    }
}
