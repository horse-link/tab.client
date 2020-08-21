using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
    public class ClientDetails 
    {
        [JsonProperty("channel")]
        public string Channel { get; set; } 
        
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; } 
    }
}