using System;
using System.Collections.Generic;
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

        [JsonProperty("scopes")]
        public List<string> scopes { get; set; } 
    }
}