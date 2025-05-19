using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using th01.Models;

namespace th01.Data
{
    public class CoffeeshopDbContext : DbContext
    {

        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) :
        base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
