using System;
using System.Collections.Generic;
using tab.client.Models.Common;
using Newtonsoft.Json;

namespace tab.client.Models.Transactions
{
    public class Transaction 
    {
        [JsonProperty("tsn")]
        public String tsn { get; set; }

        [JsonProperty("transactionReference")]
        public String TransactionReference { get; set; }

        [JsonProperty("transactionTime")]
        public DateTime TransactionTime { get; set; }

        [JsonProperty("details")]
        public Details Details { get; set; }
    }
}