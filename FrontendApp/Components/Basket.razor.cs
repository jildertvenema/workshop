using System;
using System.Linq;

namespace FrontendApp.Components
{
    public partial class Basket
    {
        private bool _basketOpen = false;

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

    }
}
