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
        private IDishService _dishService;

        public DishesController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpGet]
        [Route("dishes")]
        public async Task<Dish[]> GetAllDishesAsync()
        {
            return await _dishService.GetAllDishesAsync();
        }

        [HttpPost]
        [Route("order")]
        public async Task<ActionResult> PostOrderAsync([FromBody] Order order)
        {
            await _dishService.PostOrderAsync(order);
            return Ok();
        }

        [HttpGet]
        [Route("orders")]
        public async Task<Order[]> GetAllOrdersAsync()
        {
            return await _dishService.GetAllOrdersAsync();
        }

        [HttpPost]
        [Route("order-status/{orderGuid}")]
        public ActionResult UpdateOrderStatusAsync(string orderGuid, [FromBody] OrderStatusType orderStatus)
        {
            _dishService.UpdateOrderStatusWithGuidAsync(new Guid(orderGuid), orderStatus);
            return Ok();
        }
    }
}
