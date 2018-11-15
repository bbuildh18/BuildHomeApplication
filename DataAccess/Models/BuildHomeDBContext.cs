using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class BuildHomeDBContext : DbContext
    {
        public BuildHomeDBContext(DbContextOptions<BuildHomeDBContext> options) : base(options)
        { }

        public DbSet<Item> Items;
        public DbSet<ItemCategory> ItemCategories { get; set; }

    }

}
