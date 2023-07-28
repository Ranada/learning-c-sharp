using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class Flight
    {
        List<Booking> _bookingList { get; set; } = new List<Booking>();
        public IEnumerable<Booking> BookingsList => _bookingList;
        private int _remainingNumberOfSeats;
        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public object? Book(string email, int numberOfSeats)
        {
            if (numberOfSeats > this.RemainingNumberOfSeats)
            {
                return new OverbookingError();
            }
            Console.WriteLine($"Confirmation email sent to {email} for {numberOfSeats} seats booked.");
            RemainingNumberOfSeats -= numberOfSeats;
            Console.WriteLine($"{RemainingNumberOfSeats} seats left.");
            _bookingList.Add(new Booking(email, numberOfSeats));
            return null;
        }

        public Object? Cancel(string email, int numberOfSeats)
        {
            RemainingNumberOfSeats += numberOfSeats;
            return null;
        }

        public int RemainingNumberOfSeats
        {
            get => _remainingNumberOfSeats;
            set => _remainingNumberOfSeats = value;
        }
    }
}