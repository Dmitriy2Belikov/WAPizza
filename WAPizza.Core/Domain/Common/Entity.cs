using System;
using System.ComponentModel.DataAnnotations;
using EntityFrameworkCore.Triggers;

namespace WAPizza.Core.Domain.Common
{
    public class Entity : IEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Entity()
        {
            Triggers<Entity>.Inserting += entry => 
            {
                entry.Entity.CreatedDate = DateTime.Now.Date;
                entry.Entity.UpdatedDate = DateTime.Now.Date;
            };

            Triggers<Entity>.Updating += entry =>
            {
                entry.Entity.UpdatedDate = DateTime.Now.Date;
            };
        }
    }
}
