using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabz.gcr_codebase.DSA.scenario_based.SortingAadharNumber
{
    using System;

    public class AadharUtils : IAadharUtility
    {
        private AadharCard[] arr;
        private int size;

        public AadharUtils()
        {
            arr = new AadharCard[5];
            size = 0;
        }

        // Resize array 
        private void ResizeArray()
        {
            AadharCard[] newArr = new AadharCard[arr.Length * 2];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            arr = newArr;
        }

        // Validation 
        private bool IsValidAadhar()
        {
            Console.Write("Enter 12-digit Aadhar Number: ");
            string aadhar = Console.ReadLine();

            if (aadhar == null || aadhar.Length != 12)
            {
                Console.WriteLine("Invalid Aadhar. Must be exactly 12 digits.");
                return false;
            }

            for (int i = 0; i < 12; i++)
            {
                if (aadhar[i] < '0' || aadhar[i] > '9')
                {
                    Console.WriteLine("Invalid Aadhar. Only digits allowed.");
                    return false;
                }
            }

            // store in temp by returning through Console flow
            tempAadhar = aadhar;
            return true;
        }

        // Temporary variable (no arguments allowed in methods so store input here)
        private string tempAadhar;

        // Add Entry 
        public void AddEntry()
        {
            if (!IsValidAadhar())
                return;

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            if (size == arr.Length)
            {
                ResizeArray();
            }

            arr[size] = new AadharCard(tempAadhar, name);
            size++;

            Console.WriteLine("Entry Added Successfully.");
        }

        // Display All 
        public void DisplayAll()
        {
            if (size == 0)
            {
                Console.WriteLine("No entries found.");
                return;
            }

            for (int i = 0; i < size; i++)
            {
                arr[i].Display();
            }
        }

        // Radix Sort 
        public void RadixSort()
        {
            if (size <= 1)
            {
                Console.WriteLine("Not enough data to sort.");
                return;
            }

            // 12 digit aadhar => pos from 11 to 0
            for (int pos = 11; pos >= 0; pos--)
            {
                CountingSortByDigit(pos);
            }

            Console.WriteLine("Radix Sort Completed.");
        }

        // Counting sort by one digit position
        private void CountingSortByDigit(int pos)
        {
            AadharCard[] output = new AadharCard[size];
            int[] count = new int[10];

            for (int i = 0; i < size; i++)
            {
                int digit = arr[i].AadharNumber[pos] - '0';
                count[digit]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            // stable sort (from end)
            for (int i = size - 1; i >= 0; i--)
            {
                int digit = arr[i].AadharNumber[pos] - '0';
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            for (int i = 0; i < size; i++)
            {
                arr[i] = output[i];
            }
        }

        // Binary Search 
        public void BinarySearch()
        {
            if (size == 0)
            {
                Console.WriteLine("No entries available.");
                return;
            }

            Console.Write("Enter Aadhar Number to Search: ");
            string target = Console.ReadLine();

            if (target == null || target.Length != 12)
            {
                Console.WriteLine("Invalid Aadhar Format.");
                return;
            }

            // Binary search only works after sorting
            int low = 0;
            int high = size - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                string midAadhar = arr[mid].AadharNumber;

                int cmp = string.Compare(midAadhar, target);

                if (cmp == 0)
                {
                    Console.WriteLine("Aadhar Found");
                    arr[mid].Display();
                    return;
                }
                else if (cmp < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("Aadhar Not Found");
        }
    }

}
