using ContosoPizzaApi.Data;
using ContosoPizzaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizzaApi.Services
{
    public class PizzaService : IPizzaService
    {
        private readonly PizzaStoreContext _db;
        //static List<Pizza> Pizzas { get; }
        //static int nextId = 3;

        public PizzaService(PizzaStoreContext db)
        {
            _db = db;
            //Pizzas = new List<Pizza>
            //{ 
            //    new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false},
            //    new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true}
            //};
        }
        
        public async Task<List<PizzaSpecial>> GetSpecialsAsync()
        {
            return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
        }

        //public static List<Pizza> GetAll() => Pizzas;

        //public static Pizza? Get(int id) => Pizzas.FirstOrDefault(pizza => pizza.Id == id);

        //public static void Add(Pizza pizza)
        //{
        //    pizza.Id = nextId++;
        //    Pizzas.Add(pizza);
        //}

        //public static void Delete(int id)
        //{
        //    var pizza = Get(id);

        //    if (pizza == null)
        //    {
        //        return;
        //    }

        //    Pizzas.Remove(pizza);
        //}

        //public static void Update(Pizza pizza)
        //{
        //    var index = Pizzas.FindIndex(p => p.Id == pizza.Id);

        //    if (index == -1)
        //    {
        //        return;
        //    }

        //    Pizzas[index] = pizza;
        //}
    }
}
