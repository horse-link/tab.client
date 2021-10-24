using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
    public class MarketMover
    {
        public double ReturnWin { get; set; }
        public DateTime ReturnWinTime { get; set; }
        public bool SpecialDisplayIndicator { get; set; }
    }
}