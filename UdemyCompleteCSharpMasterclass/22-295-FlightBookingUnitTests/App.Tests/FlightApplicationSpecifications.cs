using FluentAssertions;
using System.Security.Cryptography.X509Certificates;

namespace App.Tests
{
    public class FlightApplicationSpecifications
    {
        [Fact]
        public void Books_flights()
        {
            var bookingService = new BookingService();

            bookingService.Book(new BookDto(
                flightId: Guid.NewGuid(), email: "neil.ranada@gmail.com", numberOfSeats: 2));
            
            bookingService.FindBookings().Should().ContainEquivalentOf(new BookingRm(email: "neil.ranada@gmail.com", numberOfSeats: 2));
        }
    }

    public class BookingService
    {
        public void Book(BookDto bookDto)
        {

        }

        public IEnumerable<BookingRm> FindBookings()
        {
            return new[]
            {
                new BookingRm(email: "random string", numberOfSeats: 5)
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