using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.collection_csharp_practice.gcr_codebase.collections
{
    class SetToSortedListApp
    {
        static void BubbleSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter number of elements in HashSet: ");
            int n = int.Parse(Console.ReadLine());

            HashSet<int> set = new HashSet<int>();

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                set.Add(int.Parse(Console.ReadLine()));

            List<int> sortedList = new List<int>(set);
            BubbleSort(sortedList);

            Console.WriteLine("Sorted List:");
            Console.WriteLine(string.Join(" ", sortedList));
        }
    }

}
