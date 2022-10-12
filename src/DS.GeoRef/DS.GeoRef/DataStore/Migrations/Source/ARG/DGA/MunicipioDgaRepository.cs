using DS.GeoRef.DataStore.Migrations.Source.ARG.DGA.DTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace DS.GeoRef.DataStore.Migrations.Source.ARG.DGA
{
    public class MunicipioDgaRepository : WebApiAsRepository<MunicipioDto>
    {
        public MunicipioDgaRepository(string baseUrl, string segment) : base(baseUrl, segment, "", "DatosGobAr")
        {
            
        }

        protected override void DoBeforeDeserialization(IRestResponse resp)
        {
            var doc = JsonDocument.Parse(resp.Content);
            var provincias = doc.RootElement.GetProperty("municipios");
            var content = provincias.GetRawText();
            resp.Content = content;
        }


        public List<MunicipioDto> All()
        {
            return this.InternalAll();
        }
    }
}
