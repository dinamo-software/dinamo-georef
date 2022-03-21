using System;
using System.Collections.Generic;
using System.Text;

namespace DS.GeoRef.DataStore.Migrations.Helpers
{
    public class SequenceHelper
    {
        private int seed = 1;

        public int Next()
        {
            return seed++;
        }
    }
}
