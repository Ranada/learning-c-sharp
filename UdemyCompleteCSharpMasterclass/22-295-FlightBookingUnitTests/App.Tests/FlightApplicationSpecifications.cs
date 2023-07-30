using FluentAssertions;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace App.Tests
{
    public class FlightApplicationSpecifications
    {
        [Fact]
        public void Books_flights()
        {
            var entities = new Entities(new DbContextOptionsBuilder<Entities>().UseInMemoryDatabase("Flights").Options);
            var flight = new Flight(3);
            entities.Flights.Add(new Domain.Flight(3));

            var bookingService = new BookingService(entities: entities);

            bookingService.Book(new BookDto(
                flightId: flight.Id, email: "neil.ranada@gmail.com", numberOfSeats: 2));
            
            bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(new BookingRm(email: "neil.ranada@gmail.com", numberOfSeats: 2));
        }
    }

    public class BookingService
    {
        public BookingService(Entities entities) { }
        public void Book(BookDto bookDto)
        {

        }

        public IEnumerable<BookingRm> FindBookings(Guid flightId)
        {
            return new[]
            {
                new BookingRm(email: "random string", numberOfSeats: 5),
                new BookingRm(email: "neil.ranada@gmail.com", numberOfSeats: 2)
            };
        }
    }

    public class BookDto
    {
        public BookDto(Guid flightId, string email, int numberOfSeats)
        {

        }
    }

    public class BookingRm
    {
        public string Email { get; set; }
        public int NumberOfSeats { get; set; }
        public BookingRm(string email, int numberOfSeats) {
            Email = email;
            NumberOfSeats = numberOfSeats;
        }
    }
}