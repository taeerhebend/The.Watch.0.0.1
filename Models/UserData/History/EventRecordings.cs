using System;
    using System.Text.Json.Serialization;

    namespace TheWatch.Models
    {
        public class Recording
        {
            [JsonPropertyName("id")] public string Id { get; set; }

            [JsonPropertyName("userId")] public string UserId { get; set; }

            [JsonPropertyName("timestamp")] public DateTime Timestamp { get; set; }

            [JsonPropertyName("location")] public UserLocation Location { get; set; }

            [JsonPropertyName("recordingUrl")] public string RecordingUrl { get; set; }

            // You can also add additional properties,
            // like a field for comments or a reference to the emergency event...
        }


    }

