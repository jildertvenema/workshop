using System;
using System.Threading.Tasks;
using ThuisbezorgdModels.Enum;
using ThuisbezorgdModels.Model;

namespace ThuisbezorgdModels
{
    public interface IDishService
    {
        public Task<Dish[]> GetAllDishesAsync();
        public Task PostOrderAsync(Order order);
        public Task<Order[]> GetAllOrdersAsync();
        public Task UpdateOrderStatusWithGuidAsync(Guid order, OrderStatusType orderStatusType);
    }
}
