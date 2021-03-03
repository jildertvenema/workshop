using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ThuisbezorgdModels;
using ThuisbezorgdModels.Model;

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

        public async Task PostOrderAsync(Order order)
        {
            await _httpClient.PostAsJsonAsync(BACKEND_URL + "/order", order);
        }

        public async Task<Order[]> GetAllOrdersAsync()
        {
            return await _httpClient.GetFromJsonAsync<Order[]>(BACKEND_URL + "/orders");
        }
    }
}
