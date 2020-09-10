using System;
using System.Collections.Generic;
using tab.client.Models.Common;
using Newtonsoft.Json;

namespace tab.client.Models.Transactions
{
    public class Response 
    {
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}