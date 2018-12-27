using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime ChekeIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime chekeIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            ChekeIn = chekeIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(ChekeIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            checkIn = ChekeIn;
            CheckOut = CheckOut;
        }
        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", Check-in"
                + ChekeIn.ToString("dd/MM/yyyy")
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
