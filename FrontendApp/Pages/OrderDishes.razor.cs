using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuisbezorgdModels;

namespace FrontendApp.Pages
{
    public partial class OrderDishes
    {
        private Dish[] _dishes;

        protected override async Task OnInitializedAsync()
        {
            _dishes = await dishService.GetAllDishesAsync();
        }
    }
}
