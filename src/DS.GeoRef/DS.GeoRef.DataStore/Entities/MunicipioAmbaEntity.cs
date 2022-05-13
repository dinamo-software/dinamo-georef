using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Entities
{
    public class MunicipioAmbaEntity
    {
        public int id { get; set; }
        public string municipio_code { get; set; }
        public string zona_code { get; set; }
        public string cordon_code { get; set; }
    }
}
