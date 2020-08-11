using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class RacingResult
    {
        [JsonProperty(PropertyName = "runners")]
        public List<Runner> Runners { get; set; }
    }
}