using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tab.client.Models.Race;

namespace tab.client.Models.Race
{
    public class Response 
    {
        [JsonProperty("raceNumber")]
        public Int32 RaceNumber { get; set; }

        [JsonProperty("raceName")]
        public string RaceName { get; set; }

        [JsonProperty("raceDistance")]
        public Int32 RaceDistance { get; set; }

        [JsonProperty("trackDirection")]
        public string TrackDirection { get; set; }

        [JsonProperty("hasParimutuel")]
        public bool HasParimutuel { get; set; }

        [JsonProperty("hasFixedOdds")]
        public bool HasFixedOdds { get; set; }

        [JsonProperty("hasForm")]
        public bool HasForm { get; set; }

        [JsonProperty("hasEarlySpeedRatings")]
        public bool HasEarlySpeedRatings { get; set; }

        [JsonProperty("allIn")]
        public bool AllIn { get; set; }

        [JsonProperty("cashOutEligibility")]
        public string CashOutEligibility { get; set; }

        [JsonProperty("allowBundle")]
        public bool AllowBundle { get; set; }

        [JsonProperty("willHaveFixedOdds")]
        public bool WillHaveFixedOdds { get; set; }

        [JsonProperty("fixedOddsOnlineBetting")]
        public bool FixedOddsOnlineBetting { get; set; }

        [JsonProperty("raceStartTime")]
        public DateTime RaceStartTime { get; set; }

        [JsonProperty("raceClassConditions")]
        public string RaceClassConditions { get; set; }

        [JsonProperty("apprenticesCanClaim")]
        public bool ApprenticesCanClaim { get; set; }

        [JsonProperty("prizeMoney")]
        public string PrizeMoney { get; set; }

        [JsonProperty("raceStatus")]
        public string RaceStatus { get; set; }

        [JsonProperty("substitute")]
        public string Substitute { get; set; }

        [JsonProperty("results")]
        public long[][] Results { get; set; }

        [JsonProperty("allowMulti")]
        public bool AllowMulti { get; set; }

        [JsonProperty("allowParimutuelPlace")]
        public bool AllowParimutuelPlace { get; set; }

        [JsonProperty("parimutuelPlaceStatus")]
        public string ParimutuelPlaceStatus { get; set; }

        [JsonProperty("allowFixedOddsPlace")]
        public bool AllowFixedOddsPlace { get; set; }

        [JsonProperty("numberOfPlaces")]
        public long NumberOfPlaces { get; set; }

        [JsonProperty("numberOfFixedOddsPlaces")]
        public long NumberOfFixedOddsPlaces { get; set; }

        public List<tab.client.Models.Common.Runner> runners { get; set; } 
    }
}