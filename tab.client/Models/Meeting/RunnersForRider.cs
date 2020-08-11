using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class RunnersForRider
    {
        [JsonProperty("raceNo")]
        public long RaceNo { get; set; }

        [JsonProperty("runnerNo")]
        public long RunnerNo { get; set; }

        [JsonProperty("runnerName")]
        public string RunnerName { get; set; }
    }
}