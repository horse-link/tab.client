using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tab.client.Models.Common;

namespace tab.client.Models.Betslip
{
    public class Request 
    {
        public string uuid { get; set; } 
        public string clientVersion { get; set; } 
        public ClientDetails clientDetails { get; set; } 
        public List<tab.client.Models.BetEnquiry.Bet> bets { get; set; } 
    }
}