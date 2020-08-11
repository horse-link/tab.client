using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Authentication
{
    public class Request 
    {
        public string password { get; set; } 
        public string channel { get; set; } 
        public Guid tmxSession { get; set; } 
        public List<string> scopes { get; set; } 
        public bool extendedTokenLifeTime { get; set; } 
        public int accountNumber { get; set; } 
    }    
}