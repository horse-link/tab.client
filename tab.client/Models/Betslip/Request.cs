using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tab.client.Models.Bet;

namespace tab.client.Models.Betslip
{
    public class ClientDetails 
    {
        [JsonProperty("channel")]
        public string Channel { get; set; } 
        
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; } 
    }

    public class Request 
    {
        public string uuid { get; set; } 
        public string clientVersion { get; set; } 
        public ClientDetails clientDetails { get; set; } 
        public List<Bet.Bet> bets { get; set; } 
    }
}