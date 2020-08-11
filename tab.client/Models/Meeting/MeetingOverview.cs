using System;
using Newtonsoft.Json;

namespace tab.client.Models.Meeting
{
    public class MeetingOverview
    {
        [JsonProperty("allUpAvailable")]
        public bool AllUpAvailable { get; set; }

        [JsonProperty("distance")]
        public long Distance { get; set; }

        [JsonProperty("multiLeg")]
        public string[] MultiLeg { get; set; }

        [JsonProperty("raceDate")]
        public DateTimeOffset RaceDate { get; set; }

        [JsonProperty("raceName")]
        public string RaceName { get; set; }

        [JsonProperty("raceNumber")]
        public short RaceNumber { get; set; }

        [JsonProperty("runnersLateScratched")]
        public object[] RunnersLateScratched { get; set; }

        [JsonProperty("runnersScratched")]
        public long[] RunnersScratched { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("topThreePlaceGetters")]
        public string TopThreePlaceGetters { get; set; }

        [JsonProperty("trackCondition")]
        public string TrackCondition { get; set; }

        [JsonProperty("trackRating")]
        public long TrackRating { get; set; }
    }
}