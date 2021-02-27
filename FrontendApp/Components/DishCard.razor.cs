using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendApp.Components
{
    public partial class DishCard
    {
        [Parameter]
        public string Name { get; set; }

        [Parameter]
        public string ImageUrl { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public decimal Price { get; set; }

    }
}
