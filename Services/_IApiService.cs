using System.Text;

namespace TheWatch.Services;

/// <summary>
/// Represents an API service that provides methods for making HTTP requests.
/// </summary>
public interface _IApiService
{
    /// <summary>
    /// Sends an HTTP GET request to the specified URI and returns the response as deserialized object of type T.
    /// </summary>
    /// <typeparam name="T">The type to deserialize the response to.</typeparam>
    /// <param name="uri">The URI to send the GET request to.</param>
    /// <returns>The deserialized object of type T.</returns>
    Task<T> GetAsync<T>(string uri);

    /// <summary>
    /// Sends a POST request to the specified URI with the provided data.
    /// </summary>
    /// <typeparam name="T">The type of the data being sent.</typeparam>
    /// <param name="uri">The URI to send the POST request to.</param>
    /// <param name="data">The data to be sent in the request payload.</param>
    /// <returns>A boolean value indicating whether the request was successful or not.</returns>
    Task<bool> PostAsync<T>(string uri, T data);
    // Other methods as required, such as DeleteAsync, PutAsync, etc.
}

/// <summary>
/// Provides methods for making API requests.
/// </summary>
public class _ApiService : _IApiService
{
    /// same instance of `HttpClient` for making HTTP requests throughout its lifetime.
    private readonly HttpClient _httpClient;

    /// Represents a service for making HTTP API requests.
    /// /
    public _ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Sends an HTTP GET request to the specified URI and returns the response.
    /// </summary>
    /// <typeparam name="T">The type of the object to deserialize the response content to.</typeparam>
    /// <param name="uri">The URI to send the request to.</param>
    /// <returns>The response object deserialized from the response content.</returns>
    public async Task<T> GetAsync<T>(string uri)
    {
        var response = await _httpClient.GetAsync(uri);
        // More error handling code goes here
        var data = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(data);
    }

    /// <summary>
    /// Performs an asynchronous HTTP POST request to the specified URI with the provided data.
    /// </summary>
    /// <typeparam name="T">The type of the data to be sent in the request body.</typeparam>
    /// <param name="uri">The URI to which the POST request should be sent.</param>
    /// <param name="data">The data to be sent in the request body.</param>
    /// <returns>A task representing the asynchronous operation. The task result is a boolean value indicating whether the request was successful or not.</returns>
    public async Task<bool> PostAsync<T>(string uri, T data)
    {
        var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(uri, content);
        // More error handling goes here
        return response.IsSuccessStatusCode;
    }
    
}

