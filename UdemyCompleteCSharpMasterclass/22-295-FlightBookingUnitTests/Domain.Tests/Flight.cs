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
            throw new NotImplementedException();
        }

        public int RemainingNumberOfSeats
        {
            get => _remainingNumberOfSeats;
            set => _remainingNumberOfSeats = value;
        }
    }
}