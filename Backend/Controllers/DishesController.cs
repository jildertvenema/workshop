using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ThuisbezorgdModels;
using ThuisbezorgdModels.Enum;
using ThuisbezorgdModels.Model;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DishesController : Controller
    {
        [HttpGet]
        [Route("dishes")]
        public async Task<Dish[]> GetAllDishesAsync()
        {
            // Get all dishes from DishService and return all dishes
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("order")]
        public async Task<ActionResult> PostOrderAsync([FromBody] Order order)
        {
            // Save order in DishService and Return Ok()
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("orders")]
        public async Task<Order[]> GetAllOrdersAsync()
        {
            // Get all orders from DishService and return all orders
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route("order-status/{orderGuid}")]
        public Task<ActionResult> UpdateOrderStatusAsync(string orderGuid, [FromBody] OrderStatusType orderStatus)
        {
            // Update an order status in DishService and Return Ok()
            throw new NotImplementedException();
        }
    }
}
