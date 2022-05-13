using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Entities
{
    /// <summary>
    /// Entity que contiene los datos que necesito de un Country
    /// </summary>
    public class PaisEntity
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string iso_alfa_2 { get; set; }

    }
}
