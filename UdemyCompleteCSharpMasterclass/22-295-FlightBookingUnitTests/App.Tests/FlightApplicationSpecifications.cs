using FluentAssertions;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace App.Tests
{
    public class FlightApplicationSpecifications
    {
        [Theory]
        [InlineData("name@email.com", 2)]
        [InlineData("other@email.com", 2)]
        public void Books_flights(string email, int numberOfSeats)
        {
            var entities = new Entities(new DbContextOptionsBuilder<Entities>()
                .UseInMemoryDatabase("Flights")
                .Options);
            
            var flight = new Flight(100);
            
            entities.Flights.Add(flight);

            var bookingService = new BookingService(entities: entities);

            bookingService.Book(new BookDto(flight.Id, email, numberOfSeats));
            
            bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(
                new BookingRm(email, numberOfSeats));
        }
    }

    public class BookingService
    {
        public Entities Entities { get; set; }
        public BookingService(Entities entities) {
            Entities = entities;
        }
        public void Book(BookDto bookDto)
        {
            var flight = Entities.Flights.Find(bookDto.FlightId);
            flight.Book(bookDto.Email, bookDto.NumberOfSeats);
            Entities.SaveChanges();
        }

        public IEnumerable<BookingRm> FindBookings(Guid flightId)
        {
            return Entities.Flights
                .Find(flightId).BookingList
                .Select(booking => new BookingRm(booking.Email, booking.NumberOfSeats));
        }
    }

    public class BookDto
    {
        public Guid FlightId { get; set; }
        public string Email { get; set; }
        public int NumberOfSeats { get; set; }
        public BookDto(Guid flightId, string email, int numberOfSeats)
        {
            FlightId = flightId;
            Email = email;
            NumberOfSeats = numberOfSeats;
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