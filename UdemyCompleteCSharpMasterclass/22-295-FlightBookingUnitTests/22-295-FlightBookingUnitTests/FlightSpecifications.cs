using Domain;
using FluentAssertions;

namespace App
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
            flight.BookingList.Should().ContainEquivalentOf(new Booking("neil.ranada@gmail.com", 5));
        }

        [Theory]
        [InlineData(150, 5, 4, 149)]
        [InlineData(10, 5, 5, 10)]
        [InlineData(100, 4, 1, 97)]
        public void Cancel_booking_frees_seats(int seatsAvailable, int seatsBooked, int seatsCancelled, int seatsLeft)
        {
            var flight = new Flight(seatCapacity: seatsAvailable);
            flight.Book(email: "neil.ranada@gmail.com", numberOfSeats: seatsBooked);
            flight.Cancel(email: "neil.ranada@gmail.com", numberOfSeats: seatsCancelled);
            flight.RemainingNumberOfSeats.Should().Be(seatsLeft);
        }

        [Fact]
        public void Doesnt_cancel_bookings_for_passengers_who_have_not_booked()
        {
            var flight = new Flight(seatCapacity: 100);
            var error = flight.Cancel(email: "neil.ranada@gmail.com", numberOfSeats: 2);
            error.Should().BeOfType<BookingNotFoundError>();
        }

        [Fact]
        public void Returns_null_when_successfully_cancel_booking()
        {
            var flight = new Flight(seatCapacity: 100);
            flight.Book(email: "neil.ranada@gmail.com", numberOfSeats: 2);
            var error = flight.Cancel(email: "neil.ranada@gmail.com", numberOfSeats: 2);
            Console.WriteLine(error);
            error.Should().BeNull();
        }
    }
}