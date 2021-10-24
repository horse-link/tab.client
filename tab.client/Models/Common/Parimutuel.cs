using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
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