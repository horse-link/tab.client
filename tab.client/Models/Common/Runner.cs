using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
    public class Runner
    {
        [JsonProperty(PropertyName = "runnerName")]
        public String Name { get; set; }

        [JsonProperty(PropertyName = "runnerNumber")]
        public Int32 Number { get; set; }

        [JsonProperty(PropertyName = "silkUrl")]
        public String SilkUrl { get; set; }

        [JsonProperty(PropertyName = "fixedOdds")]
        public Odds FixedOdds { get; set; }

        public Parimutuel parimutuel { get; set; } 
        public string trainerName { get; set; } 
        public bool vacantBox { get; set; } 
        public string trainerFullName { get; set; } 
        public Int16 barrierNumber { get; set; } 
        public string riderDriverName { get; set; } 
        public string riderDriverFullName { get; set; } 
        public double handicapWeight { get; set; } 
        public object harnessHandicap { get; set; } 
        public bool blinkers { get; set; } 
        public decimal claimAmount { get; set; } 
        public string last5Starts { get; set; } 
        public string tcdwIndicators { get; set; } 
        public bool emergency { get; set; } 
        public int penalty { get; set; } 
        public int dfsFormRating { get; set; } 
        public int techFormRating { get; set; } 
        public int totalRatingPoints { get; set; } 
        public int earlySpeedRating { get; set; } 
        public string earlySpeedRatingBand { get; set; } 
        //public Links2 _links { get; set; } 
    }
}