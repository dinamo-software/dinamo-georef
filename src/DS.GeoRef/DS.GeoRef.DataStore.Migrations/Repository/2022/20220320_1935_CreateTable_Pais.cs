using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{
    /// <summary>
    /// Se utilizan los codigos de paises segun norma ISO
    /// </summary>
    /// <remarks>
    /// ISO -> CODIGOS DE PAISES URL: https://es.wikipedia.org/wiki/ISO_3166-1
    /// </remarks>
    [Migration(202203201935, "Create Table Pais")]
    public class _20220320_1935_CreateTable_Pais : Migration
    {
        public override void Up()
        {

            Create.Table("pais")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_pais")
                .WithColumn("code").AsString(10).NotNullable().Unique() //ISO 3166-1 Number
                .WithColumn("name").AsString(50).NotNullable()
                .WithColumn("desc").AsString(250).Nullable()
                .WithColumn("iso_alfa_2").AsFixedLengthString(2).Nullable()
                .WithColumn("iso_alfa_3").AsFixedLengthString(3).Nullable();

        }

        public override void Down()
        {
            Delete.Table("pais");
        }
    }
}
