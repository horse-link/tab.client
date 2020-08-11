using System;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class Odds
    {
        [JsonProperty(PropertyName = "returnWin")]
        public Decimal Win { get; set; }
    }
}