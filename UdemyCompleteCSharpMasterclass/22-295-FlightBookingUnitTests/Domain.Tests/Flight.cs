namespace Domain.Tests
{
    public class Flight
    {
        private int _remainingNumberOfSeats;
        public Flight(int seatCapacity) { 
            RemainingNumberOfSeats = seatCapacity;
        }

        public void Book(string email, int seats)
        {
            Console.WriteLine($"Confirmation email sent to {email} for {seats} seats booked.");
            RemainingNumberOfSeats -= seats;
            Console.WriteLine($"{RemainingNumberOfSeats} seats left.");
        }

        public int RemainingNumberOfSeats
        {
            get => _remainingNumberOfSeats;
            set => _remainingNumberOfSeats = value;
        }
    }
}