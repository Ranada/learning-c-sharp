using Domain.Tests;
using FluentAssertions;

namespace _22_295_FlightBookingUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Book_1_seat_SeatCapacity_should_be_2()
        {
            var flight = new Flight(seatCapacity: 3);
            flight.Book("neil.ranada@outlook.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);
        }
    }
}