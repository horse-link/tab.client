using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Bet
{
    public class Request 
    {
        [JsonProperty("transactionId")]
        public Guid TransactionId { get; set; } 

        [JsonProperty("bets")]
        public List<Bet> Bets { get; set; }

        public Request()
        {
            Bets = new List<Bet>();
            TransactionId = Guid.NewGuid();
        }
    }    
}