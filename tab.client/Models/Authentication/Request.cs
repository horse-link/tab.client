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
        public Guid tmxSession { get; set; }
        public List<string> scopes { get; set; }
        public bool extendedTokenLifeTime { get; set; }
        public int accountNumber { get; set; }
    }    
}