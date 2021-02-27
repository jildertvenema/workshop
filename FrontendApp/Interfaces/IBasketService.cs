using System;
using System.Collections.Generic;
using ThuisbezorgdModels;

namespace FrontendApp.Interfaces
{
    public interface IBasketService
    {
        public void AddToBasket(Dish dish);
        public void RemoveFromBasket(Dish dish);
        public List<Dish> GetAllDishesFromBasket();
        public void ClearBasket();

        public event EventHandler OnNewDishAdded;
    }
}
