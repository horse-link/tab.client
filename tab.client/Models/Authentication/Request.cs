using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Authentication
{
    public class Request 
    {
        [JsonProperty("password")]
        public string Password { get; set; } 

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("tmxSession")]
        public Guid TmxSession { get; set; }

        [JsonProperty("scopes")]
        public List<string> Scopes { get; set; }

        [JsonProperty("extendedTokenLifeTime")]
        public bool ExtendedTokenLifeTime { get; set; }

        [JsonProperty("accountNumber")]
        public int AccountNumber { get; set; }
    }    
}