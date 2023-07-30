using FluentAssertions;
using Data;
using Domain;
using Microsoft.EntityFrameworkCore;
using App.Tests;
using System.ComponentModel.DataAnnotations;

namespace App.Tests
{
    public class FlightApplicationSpecifications
    {
        readonly Entities entities = new Entities(new DbContextOptionsBuilder<Entities>()
                .UseInMemoryDatabase("Flights")
                .Options);

        readonly BookingService bookingService;

        public FlightApplicationSpecifications()
        {
            bookingService = new BookingService(entities);
        }

        [Theory]
        [InlineData("name@email.com", 2)]
        [InlineData("other@email.com", 2)]
        public void Books_flights(string email, int numberOfSeats)
        {
            var flight = new Flight(100);

            entities.Flights.Add(flight);

            bookingService.Book(new BookDto(flight.Id, email, numberOfSeats));

            bookingService.FindBookings(flight.Id).Should().ContainEquivalentOf(
                new BookingRm(email, numberOfSeats));
        }

        [Theory]
        [InlineData(3)]
        public void Cancels_booking(int initialCapacity)
        {
            var flight = new Flight(initialCapacity);
            entities.Flights.Add(flight);

            bookingService.Book(new BookDto(flightId: flight.Id,
                email: "name@email.com",
                numberOfSeats: 2));

            bookingService.CancelBooking(
                new CancelBookingDto(
                    flightId:  flight.Id,
                    email: "name@email.com",
                    numberOfSeats: 2)
                );

            bookingService.GetRemainingNumberOfSeatsFor(flight.Id).Should().Be(initialCapacity);
        }
    }
}