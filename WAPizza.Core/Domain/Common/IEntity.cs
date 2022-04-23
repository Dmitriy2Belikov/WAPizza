using System;

namespace WAPizza.Core.Domain.Common
{
    public interface IEntity
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
