using System;
using System.Collections.Generic;
using ThuisbezorgdModels.Enum;

namespace ThuisbezorgdModels.Model
{
    public class Order
    {

        public Guid OrderGuid 
        { 
            get
            {
                return _orderGuid;
            }
            set
            {
                _orderGuid = value;
            }
        }

        public List<Dish> Dishes
        {
            get 
            {
                return _dishes;
            }
        }
        public DateTime TimeOrderPlaced
        { 
            get
            {
                return _timeOrderPlaced;
            }
        }
        public DateTime TimeLastUpdate
        { 
            get
            {
                return _timeLastUpdate;
            }
        }
        public OrderStatusType OrderStatus
        {
            get
            {
                return _orderStatus;
            }
            set
            {
                _orderStatus = value;
                _timeLastUpdate = DateTime.Now;
            }
        }

        private Guid _orderGuid;
        private List<Dish> _dishes;
        private DateTime _timeOrderPlaced;
        private DateTime _timeLastUpdate;
        private OrderStatusType _orderStatus;

        public Order(List<Dish> dishes)
        {
            _dishes = dishes;
            _orderStatus = OrderStatusType.New;
            _timeOrderPlaced = DateTime.Now;
            _timeLastUpdate = DateTime.Now;
            _orderGuid = Guid.NewGuid();
        }

    }
}
