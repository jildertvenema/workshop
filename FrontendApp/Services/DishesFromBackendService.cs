using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ThuisbezorgdModels;
using ThuisbezorgdModels.Enum;
using ThuisbezorgdModels.Model;

namespace FrontendApp.Services
{
    public class DishesFromBackendService : IDishService
    {
        private const string BACKEND_URL = "https://localhost:44360/Dishes";
        public DishesFromBackendService()
        {
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

        public async Task UpdateOrderStatusWithGuidAsync(Guid orderGuid, OrderStatusType orderStatusType)
        {
            throw new NotImplementedException();
        }
    }
}
