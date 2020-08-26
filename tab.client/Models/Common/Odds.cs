using System;
using Newtonsoft.Json;

namespace tab.client.Models.Common
{
    public class Odds 
    {
        public double ReturnWin { get; set; } 
        public DateTime ReturnWinTime { get; set; } 
        public double ReturnWinOpen { get; set; } 
        public double ReturnWinOpenDaily { get; set; } 
        public double ReturnPlace { get; set; } 
        public bool IsFavouriteWin { get; set; } 
        public bool IsFavouritePlace { get; set; } 
        public string BettingStatus { get; set; } 
        public int PropositionNumber { get; set; } 
        public object Differential { get; set; } 
        public double PercentageChange { get; set; } 
        public bool AllowPlace { get; set; } 
        public double WinDeduction { get; set; } 
        public double PlaceDeduction { get; set; } 
        public DateTime ScratchedTime { get; set; } 
        //public List<Fluc> flucs { get; set; } 
    }
}