using Microsoft.AspNetCore.Components;
using ThuisbezorgdModels.Model;

namespace FrontendApp.Components
{
    public partial class OrderListItem
    {
        [Parameter]
        public Order Order { get; set; }
    }
}
