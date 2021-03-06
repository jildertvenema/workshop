using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ThuisbezorgdModels;
using ThuisbezorgdModels.Enum;
using ThuisbezorgdModels.Model;

namespace Backend.Services
{
    public class DishesExternalApiService : IDishService
    {
        private const string EXTERNAL_DISHES_URL = "https://raw.githubusercontent.com/jildertvenema/workshop/master/EternalData/dishes.json";

        private IHttpClientFactory _httpClientFactory;
        private List<Order> _orders;

        public DishesExternalApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _orders = new List<Order>();
        }

        public async Task<Dish[]> GetAllDishesAsync()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();

            HttpResponseMessage result = await httpClient.GetAsync(EXTERNAL_DISHES_URL);
            string jsonResult = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Dish[]>(jsonResult);
        }

        public async Task PostOrderAsync(Order order)
        {
            _orders.Add(order);
            await Task.CompletedTask;
        }
        public async Task<Order[]> GetAllOrdersAsync()
        {
            return await Task.FromResult(_orders.ToArray());
        }

        public Task UpdateOrderStatusWithGuidAsync(Guid orderGuid, OrderStatusType orderStatus)
        {
            _orders.Find(order => order.OrderGuid == orderGuid).OrderStatus = orderStatus;
            return Task.CompletedTask;
        }
    }
}
