namespace TheWatch.Models;

public class Calendar
{
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; } // Unique identifier for each calendar entry.

    [JsonProperty(PropertyName = "date")]
    public DateTime Date { get; set; } // The date of the activity.

    [JsonProperty(PropertyName = "schedules")]
    public List<Schedule> Schedules { get; set; } // List of schedules in one day.

    [JsonProperty(PropertyName = "_partitionKey")]
    public string PartitionKey { get { return Id; } } // Using Id as partition key.
}