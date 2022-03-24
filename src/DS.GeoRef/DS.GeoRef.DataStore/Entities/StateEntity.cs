using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Entities
{
    /// <summary>
    /// Entity que contiene los datos que necesito de un Country
    /// </summary>
    public class StateEntity
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
}
