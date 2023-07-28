using Domain;
using FluentAssertions;

namespace _22_295_FlightBookingUnitTests
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);
            flight.Book("neil.ranada@outlook.com", 1);
            flight.RemainingNumberOfSeats.Should().Be(2);
        }
    }
}