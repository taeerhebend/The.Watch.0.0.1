using System.Text;

namespace TheWatch.Services;

public interface _IApiService
{
    Task<T> GetAsync<T>(string uri);
    Task<bool> PostAsync<T>(string uri, T data);
    // Other methods as required, such as DeleteAsync, PutAsync, etc.
}

public class _ApiService : _IApiService
{
    private readonly HttpClient _httpClient;

    public _ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T> GetAsync<T>(string uri)
    {
        var response = await _httpClient.GetAsync(uri);
        // More error handling code goes here
        var data = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(data);
    }

    public async Task<bool> PostAsync<T>(string uri, T data)
    {
        var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(uri, content);
        // More error handling goes here
        return response.IsSuccessStatusCode;
    }
    
}

