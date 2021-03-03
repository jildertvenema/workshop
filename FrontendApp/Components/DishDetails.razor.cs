using Microsoft.AspNetCore.Components;
using ThuisbezorgdModels;

namespace FrontendApp.Components
{
    public partial class DishDetails
    {
        [Parameter]
        public Dish Dish { get; set; }
    }
}
