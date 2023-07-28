using Domain;
using FluentAssertions;

namespace _22_295_FlightBookingUnitTests
{
    public class FlightSpecifications
    {
        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(6, 3, 3)]
        [InlineData(12, 4, 8)]
        public void Booking_reduces_the_number_of_seats(int numberOfSeatsAvailable, int numberOfSeatsBooked, int numberOfSeatsRemaining)
        {
            var flight = new Flight(seatCapacity: numberOfSeatsAvailable);
            flight.Book("neil.ranada@gmail.com", numberOfSeatsBooked);
            flight.RemainingNumberOfSeats.Should().Be(numberOfSeatsRemaining);
        }

        [Fact]
        public void Avoids_overbooking()
        {
            // Given
            var flight = new Flight(seatCapacity: 3);

            // When
            var error = flight.Book("neil.ranada@gmail.com", 4);

            // Then
            error.Should().BeOfType<OverbookingError>();
        }

        [Fact]
        public void Books_flights_successfully()
        {
            var flight = new Flight(seatCapacity: 3);
            var error = flight.Book("neil.ranada@gmail.com", 1);
            error.Should().BeNull();
        }

        [Fact]
        public void Remember_booked_flights()
        {
            // Given a flight with seat capacity
            var flight = new Flight(seatCapacity: 150);

            // When a new flight is booked
            flight.Book(email: "neil.ranada@gmail.com", numberOfSeats: 5) ;

            // Then a booked flight list tracks the flight
            flight.BookingsList.Should().ContainEquivalentOf(new Booking("neil.ranada@gmail.com", 5));
        }
    }
}