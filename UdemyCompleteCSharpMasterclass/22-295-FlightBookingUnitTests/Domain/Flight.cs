using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class Flight
    {
        public List<Booking> BookingsList { get; set; } = new List<Booking>();
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
            return null;
        }

        public int RemainingNumberOfSeats
        {
            get => _remainingNumberOfSeats;
            set => _remainingNumberOfSeats = value;
        }
    }
}