using System;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
    public class Authentication
    {
        [JsonProperty("token")]
        public string token { get; set; }

        [JsonProperty("inactivityExpiry")]
        public DateTime inactivityExpiry { get; set; }
        
        [JsonProperty("absoluteExpiry")]
        public DateTime absoluteExpiry { get; set; }
    }
}