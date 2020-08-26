using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Common
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