using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr the Number : ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            int idx = 0;


            int temp = num;
            // logic to to store last digit in array which is going to store whole reversed digits of a number
            while(temp != 0)
            {
                int rem = temp % 10;
                arr[idx++] = rem;
                temp /= 10;

            }

            //printing the reversed number
            Console.WriteLine("The reversed Number is : ");
            for (int i = 0; i < idx; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
