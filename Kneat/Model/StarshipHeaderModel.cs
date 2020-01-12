using Newtonsoft.Json;
using System.Collections.Generic;

namespace Kneat.Model
{
    public class StarshipHeaderModel
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }

        [JsonProperty("results")]
        public List<StarshipModel> Starships { get; set; }
    }
}
