using System;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class SellCode
    {
        [JsonProperty("meetingCode")]
        public String MeetingCode { get; set; }

        [JsonProperty("scheduledType")]
        public String ScheduledType { get; set; }
    }
}