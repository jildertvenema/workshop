using System.Threading.Tasks;

namespace ThuisbezorgdModels
{
    public interface IDishService
    {
        public Task<Dish[]> GetAllDishesAsync();
        public Task PostOrderAsync(Dish[] dishes);
    }
}
