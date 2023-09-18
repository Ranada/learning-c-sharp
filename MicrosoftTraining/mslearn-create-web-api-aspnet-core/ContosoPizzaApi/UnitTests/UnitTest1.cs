using ContosoPizzaApi.Services;

namespace UnitTests
{
    public class PizzaServiceTest
    {
        [Fact]
        public void GetAll_Pizzas_TwoPizzas()
        {
            var Pizzas = PizzaService.GetAll();
            var count = Pizzas.Count();
            Assert.Equal(2, count);
        }
    }
}