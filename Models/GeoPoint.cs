namespace TheWatch.Models;

public class GeoPoint
{
    [JsonProperty(PropertyName = "latitude")]
    public double Latitude { get; set; }

    [JsonProperty(PropertyName = "longitude")]
    public double Longitude { get; set; }
}