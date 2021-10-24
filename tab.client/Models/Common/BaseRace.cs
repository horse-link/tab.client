using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
    public abstract class BaseRace
    {
        [JsonProperty("raceNumber")]
        public int RaceNumber { get; set; }

        [JsonProperty("raceName")]
        public string RaceName { get; set; }

        [JsonProperty("raceDistance")]
        public Int32 RaceDistance { get; set; }

        [JsonProperty("trackDirection")]
        public string TrackDirection { get; set; }

        [JsonProperty("results")]
        public long[][] Results { get; set; }
    }
}