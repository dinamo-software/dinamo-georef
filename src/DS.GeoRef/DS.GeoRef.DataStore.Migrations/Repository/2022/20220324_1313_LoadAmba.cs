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
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.AlmiranteBrown });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Avellaneda });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Berazategui });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Berisso });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Brandsen });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Campana });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Canuelas });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Ensenada });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Escobar });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.EstebanEcheverria });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.ExaltacionDeLaCruz });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Ezeiza });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.FlorencioVarela });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.GeneralLasHeras });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.GeneralRodriguez });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.GeneralSanMartin });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Hurlingham });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Ituzaingo });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.JoseCPaz });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.LaMatanza });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Lanus });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.LaPlata });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.LomasDeZamora });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Lujan });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.MalvinasArgentinas });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.MarcosPaz });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Merlo });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Moreno });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Moron });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Pilar });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.PresidentePeron });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Quilmes });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.SanFernando });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.SanIsidro });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.SanMiguel });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.SanVicente });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Tigre });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.TresdeFebrero });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.VicenteLopez });
            Insert.IntoTable("amba").Row(new { id = sequence.Next(), municipio_code = MunicipiosConstants.Zarate });
        }

        public override void Down()
        {
            Delete.FromTable("amba").AllRows();
        }
    }
}
