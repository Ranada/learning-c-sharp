using ContosoPizzaApi.Services;
using FluentAssertions;

namespace UnitTests
{
    public class PizzaServiceTest
    {
        [Fact]
        public void GetAll_Pizzas_Count_Should_Be_Two()
        {
            var Pizzas = PizzaService.GetAll();
            var count = Pizzas.Count();
            count.Should().Be(2);
        }
    }
}