using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.arrays.level02
{
    internal class FrequencyOfANumber
    {
        static void Main(string[] args)
        {
            // taking input of  a number
            Console.WriteLine("Enetr the Number ");
            int num = int.Parse(Console.ReadLine());
            int count = 0; //  setting count = 0 . for counting digits

            int temp = num;

            // calculating and counting digits of a number
            while(temp != 0)
            {
                count++;
                temp /= 10;
            }

            //created an array for storing digits in array
            int[] digit = new int[count];
            int tempnum = num;
            int idx = 0; //  created index for the array

            // logic to store digits of the number in array
            while (tempnum != 0)
            {
                digit[idx++] = tempnum % 10;
                tempnum /= 10;
            }

            //created  a frequency array to store the frequency of each number
            int[]freq = new int[10];
            // counting and storing the freqeuncy
            for(int i = 0; i< count; i++)
            {
                int freqIdx = digit[i];
                freq[freqIdx]++;
            }

            // displaying the frequencies
            for(int i = 0; i < 10; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine(i + " : " + freq[i] + " times");
                }
            }

        }
    }
}
