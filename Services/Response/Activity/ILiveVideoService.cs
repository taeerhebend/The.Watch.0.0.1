namespace TheWatch.Services.Response.Activity;


public interface ILiveVideoService
{
    Task<LiveVideo> StartLiveVideo(string email);
    Task SaveLiveVideo(LiveVideo video);
}