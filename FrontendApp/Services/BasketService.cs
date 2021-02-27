using FrontendApp.Interfaces;
using System;
using System.Collections.Generic;
using ThuisbezorgdModels;

namespace FrontendApp.Services
{
    public class BasketService : IBasketService
    {
        private List<Dish> _dishes;

        public event EventHandler OnNewDishAdded;

        public BasketService()
        {
            _dishes = new List<Dish>();
        }

        public void AddToBasket(Dish dish)
        {
            int dishIndex = _dishes.IndexOf(dish);
            if (dishIndex >= 0)
            {
                _dishes[dishIndex].Amount++;
            }
            else
            {
                dish.Amount++;
                _dishes.Add(dish);
            }

            OnNewDishAdded?.Invoke(this, null);
        }

        public void ClearBasket()
        {
            this._dishes = new List<Dish>();
        }

        public List<Dish> GetAllDishesFromBasket()
        {
            return _dishes;
        }

        public void RemoveFromBasket(Dish dish)
        {
            int dishIndex = _dishes.IndexOf(dish);
            if (dishIndex >= 0)
            {
                _dishes[dishIndex].Amount--;
            }
        }
    }
}
