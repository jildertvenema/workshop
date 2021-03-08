using System;
using System.Threading.Tasks;
using ThuisbezorgdModels;

namespace FrontendApp.Pages
{
    public partial class OrderDishes
    {
        private Dish[] _dishes = Array.Empty<Dish>();

        protected override async Task OnInitializedAsync()
        {
            _dishes = await dishService.GetAllDishesAsync();
        }
    }
}
