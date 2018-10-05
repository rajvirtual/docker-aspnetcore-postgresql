using dockerapi.Maps;
using Microsoft.EntityFrameworkCore;
using dockerapi.Models;
using System;

namespace dockerapi.Models{
#pragma warning disable CS1591
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
       : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new BlogMap(modelBuilder.Entity<Blog>());
        }
    }
    #pragma warning restore CS1591
}