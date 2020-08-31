using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using tab.client.Models.Race;

namespace tab.client.Models.Runner
{
    [Obsolete]
    public class Response 
    {
        public int raceNumber { get; set; } 
        public string raceName { get; set; } 
        public int raceDistance { get; set; } 
        public string trackDirection { get; set; } 

        public List<Common.Runner> runners { get; set; } 
    }
}