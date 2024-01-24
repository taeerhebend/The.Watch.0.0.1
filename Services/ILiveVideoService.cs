namespace TheWatch.Services;


public interface ILiveVideoService
{
    Task<LiveVideo> StartLiveVideo(string email);
    Task SaveLiveVideo(LiveVideo video);
}