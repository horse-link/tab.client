using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Race
{
    public class Race 
    {
        public int raceNumber { get; set; } 
        public string raceName { get; set; } 
        public int raceDistance { get; set; } 
        public string trackDirection { get; set; } 
        //public Meeting meeting { get; set; } 
        //public SkyRacing skyRacing { get; set; } 
        public bool hasParimutuel { get; set; } 
        public bool hasFixedOdds { get; set; } 
        public object broadcastChannel { get; set; } 
        //public List<object> broadcastChannels { get; set; } 
        public bool hasForm { get; set; } 
        public bool hasEarlySpeedRatings { get; set; } 
        public bool allIn { get; set; } 
        public string cashOutEligibility { get; set; } 
        public bool allowBundle { get; set; } 
        public bool willHaveFixedOdds { get; set; } 
        public bool fixedOddsOnlineBetting { get; set; } 
        public DateTime raceStartTime { get; set; } 
        public string raceClassConditions { get; set; } 
        public bool apprenticesCanClaim { get; set; } 
        public string prizeMoney { get; set; } 
        public string raceStatus { get; set; } 
        public string substitute { get; set; } 
        //public List<object> results { get; set; } 
        //public List<Pool> pools { get; set; } 
        public bool allowMulti { get; set; } 
        public bool allowParimutuelPlace { get; set; } 
        public string parimutuelPlaceStatus { get; set; } 
        public bool allowFixedOddsPlace { get; set; } 
        public int numberOfPlaces { get; set; } 
        public int numberOfFixedOddsPlaces { get; set; } 
        public List<Runner> runners { get; set; } 
        public DateTime oddsUpdateTime { get; set; } 
        public DateTime fixedOddsUpdateTime { get; set; } 
        //public Tips tips { get; set; } 
        // public List<Rating> ratings { get; set; } 
        // public List<object> multiLegApproximates { get; set; } 
        // public List<BetType> betTypes { get; set; } 
    }

    public class BetType 
    {
        public string wageringProduct { get; set; } 
        //public FirstLeg firstLeg { get; set; } 
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

    [Obsolete("Use common")]
    public class Odds 
    {
        public double ReturnWin { get; set; } 
        public DateTime ReturnWinTime { get; set; } 
        public int ReturnWinOpen { get; set; } 
        public double ReturnWinOpenDaily { get; set; } 
        public double ReturnPlace { get; set; } 
        public bool IsFavouriteWin { get; set; } 
        public bool IsFavouritePlace { get; set; } 
        public string BettingStatus { get; set; } 
        public int PropositionNumber { get; set; } 
        public object Differential { get; set; } 
        public int PercentageChange { get; set; } 
        public bool AllowPlace { get; set; } 
        public int WinDeduction { get; set; } 
        public int PlaceDeduction { get; set; } 
        public DateTime ScratchedTime { get; set; } 
        //public List<Fluc> flucs { get; set; } 
    }

    public class MarketMover
    {
        public double ReturnWin { get; set; } 
        public DateTime ReturnWinTime { get; set; } 
        public bool SpecialDisplayIndicator { get; set; } 
    }

    public class Parimutuel 
    {
        public double ReturnWin { get; set; } 
        public double ReturnPlace { get; set; } 
        public int ReturnExact2 { get; set; } 
        public bool IsFavouriteWin { get; set; } 
        public bool IsFavouritePlace { get; set; } 
        public bool IsFavouriteExact2 { get; set; } 
        public string BettingStatus { get; set; } 
        public List<MarketMover> MarketMovers { get; set; } 
        public int? PercentageChange { get; set; } 
    }
}