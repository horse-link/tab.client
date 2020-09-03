using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Bet
{
    public class BetResponse
    {
        [JsonProperty("type")]
        public string Type { get; set; } 

        [JsonProperty("stake")]
        public string Stake { get; set; }

        [JsonProperty("enableMultiplier")]
        public Boolean EnableMultiplier { get; set; }

        [JsonProperty("betSellTime")]
        public DateTime BetSellTime { get; set; } 

        [JsonProperty("ticketSerialNumber")]
        public string TicketSerialNumber { get; set; } 

        [JsonProperty("betCost")]
        public string BetCost { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updatedTime")]
        public DateTime UpdatedTime { get; set; } 

        [JsonProperty("legs")]
        public List<Leg> Legs { get; set; }

        public BetResponse()
        {
            this.Legs = new List<Leg>();
        }
    }    
}