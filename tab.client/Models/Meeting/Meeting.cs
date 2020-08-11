using System;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class Meeting
    {
        [JsonProperty("meetingName")]
        public String MeetingName { get; set; }

        [JsonProperty("location")]
        public String Location { get; set; }

        [JsonProperty("venueMnemonic")]
        public String VenueMnemonic { get; set; }

        [JsonProperty("meetingCode")]
        public String MeetingCode { get; set; }
    }
}