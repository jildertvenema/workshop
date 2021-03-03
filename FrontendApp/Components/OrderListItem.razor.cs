using Microsoft.AspNetCore.Components;
using ThuisbezorgdModels.Enum;
using ThuisbezorgdModels.Model;

namespace FrontendApp.Components
{
    public partial class OrderListItem
    {
        [Parameter]
        public Order Order { get; set; }

        private async void UpdateOrderType(OrderStatusType orderStatusType)
        {
            await dishService.UpdateOrderStatusWithGuidAsync(Order.OrderGuid, orderStatusType);
            Order.OrderStatus = orderStatusType;

            // Render component with new state
            StateHasChanged();
        }
    }
}
