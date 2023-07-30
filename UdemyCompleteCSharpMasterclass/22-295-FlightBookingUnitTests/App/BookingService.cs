using Data;

namespace App
{
    public class BookingService
    {
        public Entities Entities { get; set; }
        public BookingService(Entities entities)
        {
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

        public void CancelBooking(CancelBookingDto cancelBookingDto)
        {
            var flight = Entities.Flights.Find(cancelBookingDto.FlightId);
            flight.Cancel(cancelBookingDto.Email, cancelBookingDto.NumberOfSeats);
        }

        public object GetRemainingNumberOfSeatsFor(Guid flightId)
        {
            return Entities.Flights.Find(flightId).RemainingNumberOfSeats;
        }
    }
}
