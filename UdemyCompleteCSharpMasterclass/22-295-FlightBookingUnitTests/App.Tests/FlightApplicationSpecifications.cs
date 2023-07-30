using FluentAssertions;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using App.Tests;

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
}