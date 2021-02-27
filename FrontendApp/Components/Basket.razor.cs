using System;

namespace FrontendApp.Components
{
    public partial class Basket
    {
        private bool _basketOpen = false;

        public Basket()
        {
        }

        protected override void OnInitialized()
        {
            basketService.OnNewDishAdded += RefreshBasketItems;
        }

        private void RefreshBasketItems (object sender, EventArgs e)
        {
            // Tell component to refresh
            StateHasChanged();
        }

        private void ToggleBasketOpen()
        {
            _basketOpen = !_basketOpen;
        }

    }
}
