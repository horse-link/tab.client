using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Betslip
{
    public class Position 
    {
        public List<int> selections { get; set; } 
    }

    public class Leg 
    {
        public List<Position> positions { get; set; } 
    }

    public class InterceptDetails 
    {
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
        public string status { get; set; } 
        public string betCost { get; set; } 
        public object flexiPercentage { get; set; } 
        public int numberOfFlexiCombinations { get; set; } 
        public List<object> errors { get; set; } 
        public DateTime updatedTime { get; set; } 
        public InterceptDetails interceptDetails { get; set; } 
    }

    public class Authentication
    {
        public string token { get; set; } 
        public DateTime inactivityExpiry { get; set; } 
        public DateTime absoluteExpiry { get; set; } 
    }

    public class Request 
    {
        public DateTime updatedTime { get; set; } 
        public string ticketCost { get; set; } 
        public List<object> errors { get; set; } 
        public int accountNumber { get; set; } 
        public List<Bet> bets { get; set; } 
        public Authentication authentication { get; set; } 
    }
}