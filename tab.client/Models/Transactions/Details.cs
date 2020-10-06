using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Transactions
{
    public class Details 
    {
        [JsonProperty("tsn")]
        public String TSN { get; set; }

        [JsonProperty("result")]
        public String Result { get; set; }

        [JsonProperty("transactionReference")]
        public String TransactionReference { get; set; }

        [JsonProperty("transactionTime")]
        public DateTime TransactionTime { get; set; }
    }
}