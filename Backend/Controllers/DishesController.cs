using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ThuisbezorgdModels;

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
    }
}
