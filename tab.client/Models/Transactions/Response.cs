using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Transactions
{
    public class Response 
    {
        [JsonProperty("transactions")]
        public List<Transaction> Transactions { get; set; }
    }
}