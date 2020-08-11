using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Betslip
{
    public class ClientDetails 
    {
        public string channel { get; set; } 
        
        public string jurisdiction { get; set; } 
    }

    // public class Leg 
    // {
    //     public string type { get; set; } 
    //     public int propositionId { get; set; } 
    //     public string odds { get; set; } 
    // }

    // public class Bet 
    // {
    //     public string type { get; set; } 
    //     public string stake { get; set; } 
    //     public List<Leg> legs { get; set; } 
    //     public bool enableMultiplier { get; set; } 
    //     public string source { get; set; } 
    // }

    public class Response 
    {
        public string uuid { get; set; } 
        public string clientVersion { get; set; } 
        public ClientDetails clientDetails { get; set; } 
        public List<Bet> bets { get; set; } 
    }
}