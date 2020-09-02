using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Bet
{
    public class Bet 
    {
        [JsonProperty("type")]
        public string Type { get; set; } 

        [JsonProperty("stake")]
        public string Stake { get; set; }

        [JsonProperty("enableMultiplier")]
        public Boolean EnableMultiplier { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("legs")]
        public List<Leg> Legs { get; set; }

        public Bet()
        {
            this.Source = "racing.race-nav.race.bet-type";
            this.Legs = new List<Leg>();
        }
    }    
}