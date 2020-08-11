using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Bet
{
    public class Position 
    {
        public List<int> selections { get; set; } 
    }

    public class Leg 
    {
        public List<Position> positions { get; set; } 
    }

    public class Bet 
    {
        public string stake { get; set; } 
        public string type { get; set; } 
        public string meetingCode { get; set; } 
        public string scheduledType { get; set; } 
        public int raceNumber { get; set; } 
        public string meetingDate { get; set; } 
        public string betType { get; set; } 
        public bool flexi { get; set; } 
        public List<Leg> legs { get; set; } 
        public bool enableMultiplier { get; set; } 
        public string source { get; set; } 
    }

    public class Request 
    {
        public string transactionId { get; set; } 
        public List<Bet> bets { get; set; } 
    }
}