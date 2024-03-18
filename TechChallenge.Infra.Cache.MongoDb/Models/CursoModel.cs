using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechChallenge.Infra.Cache.MongoDb.Models
{
    public class CursoModel
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("nome")]
        public string? Nome { get; set; }
        [JsonProperty("descricao")]
        public string? Descricao { get; set; }
        [JsonProperty("dataCurso")]
        public DateTime? DataCurso { get; set; }
        [JsonProperty("media")]
        public double? Media { get; set; }
    }
}
