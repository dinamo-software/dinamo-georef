using DS.GeoRef.DataStore.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DS.GeoRef.Tasks
{
    /// <summary>
    /// en una sola ejecución importar todas las provincias.
    /// </summary>
    public class ImportarProvinciasTask
    {
        readonly string connectionString;

        public ImportarProvinciasTask(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Execute()
        {
            var countryRegistry = new CountryDapperRepository(connectionString);

            var baseUrl = "https://apis.datos.gob.ar/georef/api";
            var segmentProvincias = "/provincias?campos=id,nombre";
            var provinciaDgaRepository = new DataStore.Migrations.Source.ARG.DGA.ProvinciaDgaRepository(baseUrl, segmentProvincias);
            var provincias = provinciaDgaRepository.All();

            //var sequence = new Helpers.SequenceHelper();
            foreach (var p in provincias)
            {
                //migrar este codigo a dapper ->
                //Insert
                //    .IntoTable("provincia")
                //    .Row(new
                //    {
                //        id = sequence.Next(),
                //        code = p.id,
                //        name = p.nombre,
                //        pais_id = countryRegistry.Get(Constants.PaisesConstants.ArgentinaCode).id
                //    });
            }
        }
    }
}
