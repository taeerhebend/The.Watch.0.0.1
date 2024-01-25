namespace TheWatch.Models.Uploads;

public class Crime
{
    public GeoPoint StartLocation { get; set; }
    public GeoPoint EndLocation { get; set; }
    
    public List<PropertiesRecalled> Properties { get; set; }
    
    
    
}