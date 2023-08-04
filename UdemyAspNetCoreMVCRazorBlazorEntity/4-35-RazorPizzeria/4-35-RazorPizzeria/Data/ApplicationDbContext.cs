using _4_35_RazorPizzeria.Models;
using Microsoft.EntityFrameworkCore;

namespace _4_35_RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
