using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class Response
    {
        [JsonProperty("meetings")]
        public List<tab.client.Models.Meeting.Meeting> Meetings { get; set; }
    }
}