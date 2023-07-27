namespace _22_295_FlightBookingUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight(seatCapacity: 3);
            flight.Book("neil.ranada@outlook.com", 1);
            flight.RemainingNumberOfSeats.ShouldBe(2);
        }
    }
}