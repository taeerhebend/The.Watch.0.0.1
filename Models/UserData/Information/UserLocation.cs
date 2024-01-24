namespace TheWatch.Models.UserData.Information;

public class UserLocation
{
    public DateTime TimeStamp { get; set; } = DateTime.Now;
    public class GeoHash
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "_partitionKey")]
        public string PartitionKey { get { return Id; } }

        [JsonProperty(PropertyName = "hashValue")]
        public string HashValue { get; set; }

        [JsonProperty(PropertyName = "point")]
        public GeoPoint Point { get; set; }
    }
}