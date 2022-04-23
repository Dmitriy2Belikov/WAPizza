using System.Collections.Generic;
using WAPizza.Core.Domain.Common;
using WAPizza.Core.Domain.Links;

namespace WAPizza.Core.Domain
{
    public class Modificator : Entity
    {
        public string Title { get; set; }

        public ICollection<MenuItemModificatorLink> MenuItems { get; set; } = new List<MenuItemModificatorLink>();
    }
}
