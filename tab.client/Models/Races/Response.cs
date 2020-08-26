using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Races
{
    public class Response
    {
        [JsonProperty("races")]
        public List<Models.Common.Race> Races { get; set; }
    }
}