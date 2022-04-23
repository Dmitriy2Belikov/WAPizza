using System.Collections.Generic;
using WAPizza.Core.Domain.Common;
using WAPizza.Core.Domain.Links;

namespace WAPizza.Core.Domain
{
    public class MenuItem : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Weight { get; set; }
        public decimal Price { get; set; }

        public long MenuSectionId { get; set; }
        public MenuSection MenuSection { get; set; }

        public ICollection<Picture> Pictures { get; set; }
        public ICollection<MenuItemModificatorLink> Modificators { get; set; } = new List<MenuItemModificatorLink>();
        public ICollection<MenuItemAdditionalIngredientLink> AdditionalIngredients { get; set; } = new List<MenuItemAdditionalIngredientLink>();
    }
}
