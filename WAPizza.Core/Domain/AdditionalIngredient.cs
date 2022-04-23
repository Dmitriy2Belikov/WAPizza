using System.Collections.Generic;
using WAPizza.Core.Domain.Common;
using WAPizza.Core.Domain.Links;

namespace WAPizza.Core.Domain
{
    public class AdditionalIngredient : Entity
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public ICollection<MenuItemAdditionalIngredientLink> MenuItems { get; set; } = new List<MenuItemAdditionalIngredientLink>();
    }
}
