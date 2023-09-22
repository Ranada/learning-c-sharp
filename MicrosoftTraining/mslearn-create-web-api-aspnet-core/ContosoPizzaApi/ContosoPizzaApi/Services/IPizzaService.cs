using ContosoPizzaApi.Models;

namespace ContosoPizzaApi.Services
{
    public interface IPizzaService
    {
        Task<List<PizzaSpecial>> GetSpecialsAsync();
    }
}