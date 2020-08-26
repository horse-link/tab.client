using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class Meeting
    {
        [JsonProperty("meetingName")]
        public String MeetingName { get; set; }

        [JsonProperty("location")]
        public String Location { get; set; }

        [JsonProperty("raceType")]
        public String RaceType { get; set; }

        [JsonProperty("meetingDate")]
        public DateTime MeetingDate { get; set; }

        [JsonProperty("prizeMoney")]
        public String PrizeMoney { get; set; }

        [JsonProperty("weatherCondition")]
        public String WeatherCondition { get; set; }

        [JsonProperty("trackCondition")]
        public String TrackCondition { get; set; }

        [JsonProperty("venueMnemonic")]
        public String VenueMnemonic { get; set; }

        [JsonProperty("sellCode")]
        public SellCode SellCode { get; set; }

        [JsonProperty("races")]
        public List<Common.Race> Races { get; set; }
    }

    public class SellCode
    {
        [JsonProperty("meetingCode")]
        public String MeetingCode { get; set; }

        [JsonProperty("scheduledType")]
        public String ScheduledType { get; set; }
    }
}