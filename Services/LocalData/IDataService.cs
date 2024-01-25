using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWatch.Services.LocalData
{
    public interface IDataService
    {
        Task<IEnumerable<T>> GetAllItemsAsync<T>() where T : class, new();

        Task<T> GetItemAsync<T>(int id) where T : class, new();

        Task<bool> AddItemAsync<T>(T item) where T : class, new();

        Task<bool> UpdateItemAsync<T>(T item) where T : class, new();

        Task<bool> DeleteItemAsync<T>(T item) where T : class, new();
    }

    public class DataService : IDataService
    {

    }

}
