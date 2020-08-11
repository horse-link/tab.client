using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tab.client.Models.Bet;

namespace tab.client.Models.Betslip
{
    public class Authentication
    {
        public string token { get; set; }
        public DateTime inactivityExpiry { get; set; }
        public DateTime absoluteExpiry { get; set; }
    }

    public class Response 
    {
        public DateTime updatedTime { get; set; } 
        public string ticketCost { get; set; } 
        public List<object> errors { get; set; } 
        public int accountNumber { get; set; } 
        public List<Bet.Bet> bets { get; set; } 
        public Authentication authentication { get; set; } 
    }
}