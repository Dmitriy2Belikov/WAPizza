using System.Collections.Generic;
using WAPizza.Core.Domain.Common;

namespace WAPizza.Core.Domain
{
    public class MenuSection : Entity
    {
        public string Title { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
