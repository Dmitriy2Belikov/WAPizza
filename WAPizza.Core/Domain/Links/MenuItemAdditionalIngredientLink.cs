using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WAPizza.Core.Domain.Links
{
    public class MenuItemAdditionalIngredientLink
    {
        [Key, Column(Order = 1)]
        public long MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }

        [Key, Column(Order = 2)]
        public long AdditionalIngredientId { get; set; }
        public AdditionalIngredient AdditionalIngredient { get; set; }
    }
}
