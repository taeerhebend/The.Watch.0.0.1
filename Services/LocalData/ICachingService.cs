namespace TheWatch.Services.LocalData;

public interface ICachingService
{
    T? RetrieveFromCache<T>(string key);
    void StoreInCache<T>(string key, T item);
    bool ContainsKey(string key);
    void ClearAllData();
}