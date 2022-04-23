using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WAPizza.Core.Domain.Links
{
    public class MenuItemModificatorLink
    {
        [Key, Column(Order = 1)]
        public long MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }

        [Key, Column(Order = 2)]
        public long ModificatorId { get; set; }
        public Modificator Modificator { get; set; }
    }
}
