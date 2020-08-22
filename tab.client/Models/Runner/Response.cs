using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tab.client.Models.Race;

namespace tab.client.Models.Runner
{
    public class Response 
    {
        public int raceNumber { get; set; } 
        public string raceName { get; set; } 
        public int raceDistance { get; set; } 
        public string trackDirection { get; set; } 

        public List<Runner> runners { get; set; } 
    }


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

        // public Parimutuel parimutuel { get; set; } 
        public string trainerName { get; set; } 
        public bool vacantBox { get; set; } 
        public string trainerFullName { get; set; } 
        public Int16 barrierNumber { get; set; } 
        public string riderDriverName { get; set; } 
        public string riderDriverFullName { get; set; } 
        public double handicapWeight { get; set; } 
        public object harnessHandicap { get; set; } 
        public bool blinkers { get; set; } 
        public int claimAmount { get; set; } 
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