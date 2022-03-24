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
    [Migration(202203241308, "Create Table Amba")]
    public class _20220324_1308_CreateTable_Amba : Migration
    {
        public override void Up()
        {
            Create.Table("amba")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_amba")
                .WithColumn("municipio_code").AsString(10).NotNullable().Unique();
        }

        public override void Down()
        {
            Delete.Table("amba");
        }
    }
}