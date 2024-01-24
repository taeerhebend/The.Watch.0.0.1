using System.Text.Json.Serialization;

namespace TheWatch.Models.WatchRequests;

public class CheckIn
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("userId")]
    public string UserId { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    // Add any other properties that you need for your application...
}