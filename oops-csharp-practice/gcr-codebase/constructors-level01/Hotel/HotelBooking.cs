using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.constructors_level01.Hotel
{
    internal class HotelBooking
    {
        // Private fields
        private string guestName;
        private string roomType;
        private int nights;

        // Default Constructor (takes input)
        public HotelBooking()
        {
            TakeInput();
        }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;
            this.roomType = roomType;
            this.nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking other)
        {
            this.guestName = other.guestName;
            this.roomType = other.roomType;
            this.nights = other.nights;
        }

        // Helper method for input (keeps constructor clean)
        private void TakeInput()
        {
            Console.WriteLine("Enter Guest Name:");
            guestName = Console.ReadLine();

            Console.WriteLine("Enter Room Type (Single/Double/Deluxe):");
            roomType = Console.ReadLine();

            Console.WriteLine("Enter Number of Nights:");
            nights = int.Parse(Console.ReadLine());
        }

        // Display method
        public void Display()
        {
            Console.WriteLine("\nBooking Details");
            Console.WriteLine($"Guest Name : {guestName}");
            Console.WriteLine($"Room Type  : {roomType}");
            Console.WriteLine($"Nights     : {nights}");
        }
    }
}
