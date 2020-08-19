using System;
using System.Collections.Generic;
using Newtonsoft.Json;

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
        public List<tab.client.Models.BetEnquiry.Bet> bets { get; set; } 
    }
}