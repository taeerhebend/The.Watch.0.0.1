namespace TheWatch.Models;

public class FirstResponder
{
    [JsonProperty(PropertyName = "id", NullValueHandling = NullValueHandling.Ignore)]
    public string Id { get; set; }
        
}