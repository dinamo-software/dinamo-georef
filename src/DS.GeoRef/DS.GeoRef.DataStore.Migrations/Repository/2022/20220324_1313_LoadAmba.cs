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
                municipio_code = MunicipiosAmbaConstants.AlmiranteBrown,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Avellaneda,
                zona_code = ZonasConstants.Sur,
                cordon_code = "01"
            });
            
            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Berazategui,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Berisso,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Brandsen,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Campana,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Canuelas,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });
            
            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Ensenada,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Escobar,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.EstebanEcheverria,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.ExaltacionDeLaCruz,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Ezeiza,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.FlorencioVarela,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.GeneralLasHeras,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.GeneralRodriguez,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.GeneralSanMartin,
                zona_code = ZonasConstants.Norte,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Hurlingham,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Ituzaingo,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.JoseCPaz,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.LaMatanza,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Lanus,
                zona_code = ZonasConstants.Sur,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.LaPlata,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.LomasDeZamora,
                zona_code = ZonasConstants.Sur,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Lujan,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.MalvinasArgentinas,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.MarcosPaz,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Merlo,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Moreno,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Moron,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Pilar,
                zona_code = ZonasConstants.Norte,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.PresidentePeron,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Quilmes,
                zona_code = ZonasConstants.Sur,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.SanFernando,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.SanIsidro,
                zona_code = ZonasConstants.Norte,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.SanMiguel,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.SanVicente,
                zona_code = ZonasConstants.Sur,
                cordon_code = "03"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Tigre,
                zona_code = ZonasConstants.Norte,
                cordon_code = "02"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.TresdeFebrero,
                zona_code = ZonasConstants.Oeste,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.VicenteLopez,
                zona_code = ZonasConstants.Norte,
                cordon_code = "01"
            });

            Insert.IntoTable("amba").Row(new { 
                id = sequence.Next(), 
                municipio_code = MunicipiosAmbaConstants.Zarate,
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
