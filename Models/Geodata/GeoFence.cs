namespace TheWatch.Models;


public class GeoFence
{
    // Cosmos DB will auto-generate the Id if it is null during insertion
    [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    [JsonProperty(PropertyName = "_partitionKey")]
    public string PartitionKey { get { return Id; } }

    [JsonProperty(PropertyName = "name")] 
    public string Name { get; set; }

    [JsonProperty(PropertyName = "coordinates")]
    public List<GeoPoint> Coordinates { get; set; }
}