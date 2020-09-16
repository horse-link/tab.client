using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Transactions
{
    public class Details 
    {
        [JsonProperty("result")]
        public String Result { get; set; }
    }
}