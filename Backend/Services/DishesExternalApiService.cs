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
            throw new NotImplementedException();
        }

        public async Task<Dish[]> GetAllDishesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task PostOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }
        public async Task<Order[]> GetAllOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderStatusWithGuidAsync(Guid orderGuid, OrderStatusType orderStatus)
        {
            throw new NotImplementedException();
        }
    }
}
