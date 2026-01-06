using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.review.AddressBookingSystem
{
    public class Utility
    {
        private Address[][] addresses;
        private int count;

        public Utility(int size)
        {
            addresses = new Address[size][];
            count = 0;

            // preload 10 addresses
            Add(new Address(560001, "Central", "Karnataka", "Bangalore"));
            Add(new Address(110001, "North", "Delhi", "New Delhi"));
            Add(new Address(400001, "West", "Maharashtra", "Mumbai"));
            Add(new Address(600001, "South", "Tamil Nadu", "Chennai"));
            Add(new Address(700001, "East", "West Bengal", "Kolkata"));
            Add(new Address(500001, "South", "Telangana", "Hyderabad"));
            Add(new Address(302001, "West", "Rajasthan", "Jaipur"));
            Add(new Address(380001, "West", "Gujarat", "Ahmedabad"));
            Add(new Address(751001, "East", "Odisha", "Bhubaneswar"));
            Add(new Address(800001, "East", "Bihar", "Patna"));
        }

        // add address
        public void Add(Address address)
        {
            addresses[count] = new Address[1];
            addresses[count][0] = address;
            count++;
        }

        // search by substring
        public void Search(string key)
        {
            
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                Address a = addresses[i][0];

                if (a.GetPin().ToString().Contains(key) ||
                    a.GetRegion().Contains(key) ||
                    a.GetState().Contains(key) ||
                    a.GetTown().Contains(key))
                {
                    Console.WriteLine(a);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching address found.");
            }
        }

        // sort by pin
        public void SortByPin()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (addresses[i][0].GetPin() > addresses[j][0].GetPin())
                    {
                        var temp = addresses[i];
                        addresses[i] = addresses[j];
                        addresses[j] = temp;
                    }
                }
            }
        }

        // display all
        public void DisplayAll()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(addresses[i][0]);
            }
        }
    }
}
