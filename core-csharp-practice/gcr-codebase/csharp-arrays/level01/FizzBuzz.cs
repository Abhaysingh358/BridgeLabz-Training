using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level01
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enetr the NUmber : ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("enter the number greater than 0 : ");
                return;
            }

            String[] result = new string[num + 1];

            for (int i = 0; i <= num; i++)
            {
                //checking if i== 0 then division can be possible
                if (i != 0)
                {

                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        result[i] = "FizzBuzz";
                    }

                    else if (i % 3 == 0)
                    {
                        result[i] = "Fizz";
                    }

                    else if (i % 5 == 0)
                    {
                        result[i] = "Buzz";
                    }
                    else
                    {
                        result[i] = i.ToString();
                    }
                }



            }
            // displaying the result
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine($" Position {i} = {result[i]}");
            }
        }
    }
}
