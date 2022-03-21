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
    [Migration(202203201955, "Create Table Provincia")]
    public class _20220320_1955_CreateTable_Provincia : Migration
    {
        public override void Up()
        {

            Create.Table("provincia")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_provincia")
                .WithColumn("code").AsString(10).NotNullable().Unique() //GeoRefAr Code
                .WithColumn("name").AsString(100).NotNullable()
                .WithColumn("desc").AsString(500).Nullable()
                .WithColumn("pais_id").AsInt32().NotNullable().ForeignKey("FK_provincia_pais", "pais", "id");
        }

        public override void Down()
        {
            Delete.Table("provincia");
        }
    }
}
