using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class Rider
    {
        [JsonProperty("riderName")]
        public string RiderName { get; set; }

        [JsonProperty("runnersForRider")]
        public RunnersForRider[] RunnersForRider { get; set; }
    }
}