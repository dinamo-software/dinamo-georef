using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations.Repository._2022
{
    [Migration(20220510_1615, "Create Table Tarea")]
    public class _20220510_1615_CreateTable_Tareas : Migration
    {
        public override void Up()
        {
            //id, code, name, type, completed (boolean)
            Create.Table("tarea")
                .WithColumn("id").AsInt32().NotNullable().Unique().Identity().PrimaryKey("PK_Tarea")
                .WithColumn("code").AsString(10).NotNullable().Unique()
                .WithColumn("name").AsString(100).NotNullable()
                .WithColumn("type").AsString(100).Nullable()
                .WithColumn("completed").AsBoolean().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("tarea");
        }
    }
}
