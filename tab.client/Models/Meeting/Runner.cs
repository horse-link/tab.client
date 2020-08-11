using System;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class Runner
    {
        [JsonProperty(PropertyName = "runnerName")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "runnerNumber")]
        public Int32 Number { get; set; }

        [JsonProperty(PropertyName = "silkUrl")]
        public String SilkUrl { get; set; }

        [JsonProperty(PropertyName = "fixedOdds")]
        public Odds FixedOdds { get; set; }
    }
}