using System;
using CustomException.Entities;
using CustomException.Entities.Exceptions;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation " + reservation);

                Console.WriteLine("-------------------------------------- ");

                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation " + reservation);

                Console.ReadLine();
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in reservation " + e.Message);
                Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("Don't Panic format error " + e.Message);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Don't Panic generic error " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
