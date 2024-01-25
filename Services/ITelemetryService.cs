namespace TheWatch.Services;

public interface ITelemetryService
{
    void TrackEvent(string name, Dictionary<string, string>? properties = null);
    void LogException(Exception exception, Dictionary<string, string>? properties = null);
}