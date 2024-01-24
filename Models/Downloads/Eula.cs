namespace TheWatch.Models.Downloads;

public class Eula
{
    // Cosmos DB will auto-generate the Id if it is null during insertion
    [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }

    public string Text { get; set; }


}