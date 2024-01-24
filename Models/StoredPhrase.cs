namespace TheWatch.Models;

public class StoredPhrase
{
    // Cosmos DB will auto-generate the Id if it is null during insertion
    [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
    public string UserId { get; set; }
    public DateTime TimeStamp { get; set; } = DateTime.Now;
    public string PhraseTranscription { get; set; }
}

