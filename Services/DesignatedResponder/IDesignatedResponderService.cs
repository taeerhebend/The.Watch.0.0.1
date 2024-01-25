namespace TheWatch.Services;

public interface IDesignatedResponderService
{
    Task RegisterAsResponder(string email, Availability availability);
    Task RespondToCheckinRequest(string responderEmail, string checkinId, CheckinResponseStatus responseStatus);
}