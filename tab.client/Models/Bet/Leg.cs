using System;
using Newtonsoft.Json;

namespace tab.client.Models.Bet
{
    public class Leg 
    {
        [JsonProperty("type")]
        public String Type { get; set; } 

        [JsonProperty("propositionId")]
        public Int64 PropositionId { get; set; }

        [JsonProperty("odds")]
        public String Odds { get; set; }
    }    
}