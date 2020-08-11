using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class MeetingOverviewResponse
    {
        [JsonProperty("meetingOverview")]
        public List<MeetingOverview> MeetingOverview { get; set; }

        [JsonProperty("riders")]
        public List<Rider> Riders { get; set; }
    }
}