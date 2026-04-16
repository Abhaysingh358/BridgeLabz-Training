using BridgeLabz.gcr_codebase.DSA.LinkedList.CircularLinkedList.TicketReservation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.Comparision
{
    internal class CompareUsingTicks
    {
        public void Compare()
        {
            Console.WriteLine("How Many Time you want concatenate , please enter");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPerformance Comparison using DateTime.Ticks \n");

            long startofString = DateTime.Now.Ticks;
            string s = "";
            for(int i = 0; i < num; i++)
            {
                s += "A";
            }

            long endofString = DateTime.Now.Ticks;

            long ticksofString =endofString - startofString;
            Console.WriteLine("Normal String (+) Time: " + ticksofString + " ticks");

            long startofStrBuilder = DateTime.Now.Ticks;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append("A");
            }

            string result = sb.ToString();

            long endofstrBuilder = DateTime.Now.Ticks;
            long ticksofstrBuilder = endofstrBuilder - startofStrBuilder;
            Console.WriteLine("StringBuilder Time:     " + ticksofstrBuilder + " ticks");

            Console.WriteLine("\nFinal Length: " + result.Length);

        }
    }
}
