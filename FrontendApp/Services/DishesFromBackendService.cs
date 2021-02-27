using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ThuisbezorgdModels;

namespace FrontendApp.Services
{
    public class DishesFromBackendService : IDishService
    {
        HttpClient _httpClient;
        private const string BACKEND_URL = "https://localhost:44360/Dishes";
        public DishesFromBackendService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Dish[]> GetAllDishesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Dish[]>(BACKEND_URL + "/dishes");
        }

        public Task PostOrderAsync(Dish[] dishes)
        {
            throw new NotImplementedException();
        }
    }
}
