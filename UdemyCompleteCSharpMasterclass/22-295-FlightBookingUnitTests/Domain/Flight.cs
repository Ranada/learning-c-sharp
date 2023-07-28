namespace Domain
{
    public class Flight
    {
        private int _remainingNumberOfSeats;
        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public void Book(string email, int numberOfSeats)
        {
            Console.WriteLine($"Confirmation email sent to {email} for {numberOfSeats} seats booked.");
            RemainingNumberOfSeats -= numberOfSeats;
            Console.WriteLine($"{RemainingNumberOfSeats} seats left.");
        }

        public int RemainingNumberOfSeats
        {
            get => _remainingNumberOfSeats;
            set => _remainingNumberOfSeats = value;
        }
    }
}