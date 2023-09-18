using ContosoPizzaApi.Services;
using FluentAssertions;

namespace UnitTests
{
    public class PizzaServiceTest
    {
        [Fact]
        public void GetAll_Pizzas_Count_Should_Be_Two()
        => PizzaService.GetAll().Count().Should().Be(2);
    }
}