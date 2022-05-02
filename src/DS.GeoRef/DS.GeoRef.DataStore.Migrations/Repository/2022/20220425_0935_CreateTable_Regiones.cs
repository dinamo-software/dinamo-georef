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

    [Migration(20220425_0935, "Crear tabla regiones")]
    public class _20220425_0935_CreateTable_Regiones : Migration
    {
        public override void Up()
        {
            Create.Table("region")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_region")
                .WithColumn("code").AsString(10).NotNullable().Unique() //GeoRefAr Code
                .WithColumn("name").AsString(100).NotNullable();


            Create.Table("region_detalle")
                .WithColumn("id").AsInt32().NotNullable().PrimaryKey("PK_region_detalle")
                .WithColumn("region_id").AsInt32().NotNullable().ForeignKey("FK_region_detalle_region", "region", "id")
                .WithColumn("level").AsString(1).NotNullable()
                .WithColumn("item_code").AsString(10).NotNullable();
        }

        public override void Down()
        {
            Delete.Table("region_detalle");
            Delete.Table("region");
        }
    }
}
