

using System;
using System.Text.Json.Serialization;

namespace TheWatch.Models
{
    public class Evacuation
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("origin")] public GeoPoint Origin { get; set; }

        [JsonPropertyName("destination")] public GeoPoint Destination { get; set; }

        [JsonPropertyName("userId")] public string UserId { get; set; }

        // Other properties related to the evacuation can be added here...
    }

    public class GeoPoint
    {
        [JsonPropertyName("latitude")] public double Latitude { get; set; }

        [JsonPropertyName("longitude")] public double Longitude { get; set; }

        [JsonPropertyName("address")] public string Address { get; set; }
    }
}
}