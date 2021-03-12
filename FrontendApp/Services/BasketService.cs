using FrontendApp.Interfaces;
using System;
using System.Collections.Generic;
using ThuisbezorgdModels;

namespace FrontendApp.Services
{
    public class BasketService : IBasketService
    {
        public event EventHandler OnNewDishAdded;
        private List<Dish> _dishes;

        public BasketService()
        {
            throw new NotImplementedException();
        }

        public void AddToBasket(Dish dish)
        {
            throw new NotImplementedException();
        }

        public void ClearBasket()
        {
            throw new NotImplementedException();
        }

        public List<Dish> GetAllDishesFromBasket()
        {
            throw new NotImplementedException();
        }

        public void RemoveFromBasket(Dish dish)
        {
            throw new NotImplementedException();
        }
    }
}
