using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.core_csharp_practice.gcr_codebase.csharp_methods.level02
{
    internal class FriendsAgeHeight
    {
        // Function to find the index of the tallest friend
        public int tallest(double[] height)
        {
            double maxHt = height[0];
            int idx  = 0;
            // Iterate through the height array to find the maximum height
            for (int i = 0; i < height.Length; i++)
            {
                // Compare each height with the current maximum height
                if (height[i] > maxHt)
                {
                    maxHt = height[i];

                    idx = i;
                }
            }
            return idx;
        }

        // Function to find the index of the youngest friend
        public int youngest(int[] age)
        {
            int minage = age[0];
            int idx = 0;
            // Iterate through the age array to find the minimum age
            for (int i = 0; i < age.Length; i++)
            {
                // Compare each age with the current minimum age
                if (age[i] < minage)
                {
                    minage = age[i];
                    idx = i;
                }
            }
            return idx;
        }

        static void Main(string[] args)
        {
            String[] friends = { "Amar ", "Akbar" , "Anthony" };
            int[] age = new int[3];
            double[] height = new double[3];

            // Input age and height for each friend
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine("Enter the age of " + friends[i] + " : ");
                age[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the height (in cm) of " + friends[i] + " : ");
                height[i] = double.Parse(Console.ReadLine());
            }

            FriendsAgeHeight f = new FriendsAgeHeight();

            int youngestIdx = f.youngest(age);
            int tallestIdx = f.tallest(height);
             Console.WriteLine(friends[youngestIdx] + " is the youngest friend : " +  " with age " + age[youngestIdx]);
            Console.WriteLine(friends[tallestIdx] + "is the tallest friend : " + " with height " + height[tallestIdx] + " cm");


        }
    }
}
