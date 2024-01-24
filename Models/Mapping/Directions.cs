



using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TheWatch.Models.Mapping
{
    public class Direction
    {
        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("originUserId")] public string OriginUserId { get; set; }

        [JsonPropertyName("destinationLocation")]
        public string DestinationLocation { get; set; }

        [JsonPropertyName("route")] public Route Route { get; set; }
    }

    public class Route
    {
        [JsonPropertyName("summary")] public Summary Summary { get; set; }

        [JsonPropertyName("legs")] public List<Leg> Legs { get; set; }
    }

    public class Summary
    {
        [JsonPropertyName("lengthInMeters")] public int LengthInMeters { get; set; }

        [JsonPropertyName("travelTimeInSeconds")]
        public int TravelTimeInSeconds { get; set; }

        // ... other properties according to Azure Maps Direction API
    }

    public class Leg
    {
        [JsonPropertyName("summary")] public Summary Summary { get; set; }

        [JsonPropertyName("points")] public List<Point> Points { get; set; }
    }

    public class Point
    {
        [JsonPropertyName("longitude")] public double Longitude { get; set; }

        [JsonPropertyName("latitude")] public double Latitude { get; set; }
    }

    //... other classes according to Azure Maps Direction API
}
