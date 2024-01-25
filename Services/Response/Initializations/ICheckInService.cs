namespace TheWatch.Services.Response.Initializations;

public interface ICheckinService
{
    Task<Checkin> RequestCheckin(string email, CheckinRequest request);
    Task<CheckinStatus> GetCheckinStatus(string checkinId);
}