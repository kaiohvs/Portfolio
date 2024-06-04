using Microsoft.EntityFrameworkCore;
using Portfolio.MVC.Models;
using System.Collections.Generic;

namespace Portfolio.MVC.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}