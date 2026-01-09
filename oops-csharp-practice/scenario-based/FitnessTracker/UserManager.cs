using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.oops_csharp_practice.scenario_based.FitnessTracker
{
    using System;

    public class UserManager
    {
        private UserProfile[] users = new UserProfile[10];
        private int count = 0;

        public void AddUser()
        {
            UserProfile user = new UserProfile();

            Console.Write("User Id: ");
            user.SetUserId(int.Parse(Console.ReadLine()));

            Console.Write("Name: ");
            user.SetName(Console.ReadLine());

            Console.Write("Age: ");
            user.SetAge(int.Parse(Console.ReadLine()));

            Console.Write("Weight (kg): ");
            user.SetWeight(double.Parse(Console.ReadLine()));

            Console.Write("Height (m): ");
            user.SetHeight(double.Parse(Console.ReadLine()));

            users[count] = user;
            count++;
        }

        public void ViewAllUsers()
        {
            if (count == 0)
            {
                Console.WriteLine("No users found.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(users[i]);
            }
        }

        public bool UserExists(int userId)
        {
            for (int i = 0; i < count; i++)
            {
                if (users[i].GetUserId() == userId)
                {
                    return true;
                }
            }
            return false;
        }
    }

}
