namespace TheWatch.Models;

public class Schedule
{
    [JsonProperty(PropertyName = "startTime")]
    public TimeSpan StartTime { get; set; } // Start time of the activity, in hours.

    [JsonProperty(PropertyName = "endTime")]
    public TimeSpan EndTime { get; set; } // End time of the activity, in hours.

    [JsonProperty(PropertyName = "activity")]
    public string Activity { get; set; } // A description of the scheduled activity.
}