using _10_142_polymorphism;
using FluentAssertions;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void New_BMW_inherits_from_Car_class_and_has_Model()
        {
            Audi myCar = new BMW("500", "Black", "Z4");
            myCar.HP.Should().Be("500");
            myCar.Color.Should().Be("Black");
            myCar.Model.Should().Be("Z4");
        }
    }
}