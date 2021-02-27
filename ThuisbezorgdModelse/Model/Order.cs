using System;
using System.Collections.Generic;

namespace ThuisbezorgdModels.Model
{
    class Order
    {
        public List<Dish> Dishes { get; set; }
        public DateTime TimeOrderPlaced { get; set; }
        public string OrderStatus { get; set; }
    }
}
