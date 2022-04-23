using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WAPizza.Core.Domain;
using WAPizza.Core.Domain.Links;

namespace WAPizza.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AdditionalIngredient> AdditionalIngredients { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<MenuSection> MenuSections { get; set; }
        public DbSet<Modificator> Modificators { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        public DbSet<MenuItemModificatorLink> MenuItemModificatorLinks { get; set; }
        public DbSet<MenuItemAdditionalIngredientLink> MenuItemAdditionalIngredientLinks { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<MenuItemModificatorLink>()
                .HasKey(x => new {x.MenuItemId, x.ModificatorId});

            modelBuilder
                .Entity<MenuItemAdditionalIngredientLink>()
                .HasKey(x => new { x.MenuItemId, x.AdditionalIngredientId });
        }
    }
}
