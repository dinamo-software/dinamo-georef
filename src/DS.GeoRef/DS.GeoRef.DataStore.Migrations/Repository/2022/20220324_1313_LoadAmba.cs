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
        /*El Primer Cordón abarca Avellaneda, Lanús, 
         * Lomas de Zamora, La Matanza (una parte), Morón, 
         * Tres de Febrero, San Martín, Vicente López, San Isidro.

El Segundo Cordón: Quilmes, Berazategui, Florencio Varela, Esteban Echeverría, Ezeiza, Moreno, 
        Merlo, Malvinas Argentinas, Hurlingham, Ituzaingó, Tigre, San Fernando, José C. Paz, San Miguel, 
        La Matanza (otra parte), Almirante Brown.*/

        //El tercer cordón: La Plata, Berisso, Ensenada, San Vicente, Pte. Perón, Marcos Paz, Gral. Rodríguez, Escobar y Pilar.
        public override void Up()
        {
            var sequence = new Helpers.SequenceHelper();
            
            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.AlmiranteBrown,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Avellaneda,
                zona_code = ZonasConstants.Sur,
                cordon_code = "01"
            });
            
            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Berazategui,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Berisso,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Brandsen,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Campana,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Canuelas,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });
            
            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Ensenada,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Escobar,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.EstebanEcheverria,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.ExaltacionDeLaCruz,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Ezeiza,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.FlorencioVarela,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.GeneralLasHeras,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.GeneralRodriguez,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.GeneralSanMartin,
                zona_code = ZonasConstants.Norte,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Hurlingham,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Ituzaingo,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.JoseCPaz,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.LaMatanza,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Lanus,
                zona_code = ZonasConstants.Sur,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.LaPlata,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.LomasDeZamora,
                zona_code = ZonasConstants.Sur,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Lujan,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.MalvinasArgentinas,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.MarcosPaz,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Merlo,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Moreno,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Moron,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Pilar,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.PresidentePeron,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Quilmes,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.SanFernando,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.SanIsidro,
                zona_code = ZonasConstants.Norte,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.SanMiguel,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.SanVicente,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Tigre,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.TresdeFebrero,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.VicenteLopez,
                zona_code = ZonasConstants.Norte,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosConstants.Zarate,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

        }

        public override void Down()
        {
            Delete.FromTable("amba").AllRows();
        }
    }
}
