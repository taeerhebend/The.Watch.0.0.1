// Interface for Telemetry Service: Tracks events and logs exceptions, useful for analytics and diagnostic purposes.

namespace TheWatch.Services.Alerts;

public interface ITelemetryService
{
    void TrackEvent(string name, Dictionary<string, string>? properties = null);
    void LogException(Exception exception, Dictionary<string, string>? properties = null);
}