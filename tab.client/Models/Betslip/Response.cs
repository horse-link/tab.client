using System;
using System.Collections.Generic;
using tab.client.Models.Common;
using Newtonsoft.Json;

namespace tab.client.Models.Betslip
{
    public class Response 
    {
        public DateTime updatedTime { get; set; } 
        public string ticketCost { get; set; } 
        public List<object> errors { get; set; } 
        public int accountNumber { get; set; } 
        public List<tab.client.Models.BetEnquiry.Bet> bets { get; set; } 
        public tab.client.Models.Common.Authentication authentication { get; set; } 
    }
}