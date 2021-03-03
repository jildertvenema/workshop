using System.Threading.Tasks;
using ThuisbezorgdModels.Model;

namespace FrontendApp.Pages
{
    public partial class Orders
    {
        Order[] _orders;
        protected override async Task OnInitializedAsync()
        {
            _orders = await dishService.GetAllOrdersAsync();
        }
    }
}
