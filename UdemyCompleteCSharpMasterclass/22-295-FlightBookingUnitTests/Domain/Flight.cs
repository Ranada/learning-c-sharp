﻿using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class Flight
    {
        List<Booking> _bookingList { get; set; } = new List<Booking>();
        public IEnumerable<Booking> BookingList => _bookingList;
        private int _remainingNumberOfSeats;
        public Guid Id { get; }

        [Obsolete("Needed by EF")]
        Flight() { }    

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

            RemainingNumberOfSeats -= numberOfSeats;

            _bookingList.Add(new Booking(email, numberOfSeats));
            return null;
        }

        public Object? Cancel(string email, int numberOfSeats)
        {
            if (!BookingList.Any(booking => booking.Email == email))
                return new BookingNotFoundError();

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