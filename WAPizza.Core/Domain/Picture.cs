using WAPizza.Core.Domain.Common;

namespace WAPizza.Core.Domain
{
    public class Picture : Entity
    {
        public string FilePath { get; set; }
        public string RelativePath { get; set; }

        public long MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
