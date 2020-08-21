using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.BetEnquiry
{
    public class Leg
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("propositionId")]
        public long PropositionId { get; set; }

        [JsonProperty("odds")]
        public string Odds { get; set; }
    }

    public class ClientDetails
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }
    }

    public class Bet
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("stake")]
        public string Stake { get; set; }

        [JsonProperty("legs")]
        public Leg[] Legs { get; set; }

        [JsonProperty("enableMultiplier")]
        public bool EnableMultiplier { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }
    }

    public class Request
    {
        [JsonProperty("uuid")]
        public Guid Uuid { get; set; }

        [JsonProperty("clientVersion")]
        public String ClientVersion { get; set; }

        [JsonProperty("clientDetails")]
        public ClientDetails ClientDetails { get; set; }

        [JsonProperty("bets")]
        public List<Bet> Bets { get; set; }

        public Request()
        {
            Uuid = Guid.NewGuid();
            ClientVersion = "1";

            ClientDetails = new ClientDetails()
            {
                Channel = "TABCOMAU",
                Jurisdiction = "QLD"
            };
        }
    }
}