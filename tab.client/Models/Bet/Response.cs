using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Bet
{
    public class Response 
    {
        [JsonProperty("updatedTime")]
        public DateTime UpdatedTime { get; set; } 

        [JsonProperty("ticketCost")]
        public String TicketCost { get; set; } 

        [JsonProperty("bets")]
        public List<Bet> Bets { get; set; }

        public Response()
        {
            Bets = new List<Bet>();
        }
    }    
}