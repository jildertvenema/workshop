using FrontendApp.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using ThuisbezorgdModels;
using ThuisbezorgdModels.Model;

namespace FrontendApp.Components
{
    public partial class Basket
    {
        private bool _basketOpen = false;

        // REMOVE THIS CODE \/
        private IDishService dishService;
        private IBasketService basketService;
        // REMOVE THIS CODE /\

        protected override void OnInitialized()
        {
            basketService.OnNewDishAdded += RefreshBasketItems;
        }

        private void RefreshBasketItems (object sender, EventArgs e)
        {
            // Tell component to refresh
            StateHasChanged();
        }

        private decimal GetTotalPrice()
        {
            return basketService.GetAllDishesFromBasket().Sum(dish => dish.Amount * dish.Price);
        }

        private void ToggleBasketOpen()
        {
            _basketOpen = !_basketOpen;
        }

        private async Task PlaceOrder()
        {
            await dishService.PostOrderAsync(new Order(basketService.GetAllDishesFromBasket()));
            basketService.ClearBasket();
        }
    }
}
