using ContosoPizzaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizzaApi.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
    { 
    }

    public DbSet<PizzaSpecial> Specials { get; set; }

}
