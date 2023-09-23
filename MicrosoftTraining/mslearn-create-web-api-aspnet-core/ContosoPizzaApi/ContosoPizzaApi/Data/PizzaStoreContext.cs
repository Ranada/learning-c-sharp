using ContosoPizzaApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizzaApi.Data;

public class PizzaStoreContext : IdentityDbContext<User>
{
    public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
    { 
    }

    public DbSet<PizzaSpecial> Specials { get; set; }

}
