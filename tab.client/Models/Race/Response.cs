using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Race
{
    public class Response 
    {
        [JsonProperty("races")]
        public List<Models.Race.Race> Races { get; set; }
    }
}