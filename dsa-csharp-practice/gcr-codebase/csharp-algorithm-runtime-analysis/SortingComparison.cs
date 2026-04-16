using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.csharp_algorithm_runtime_analysis
{
    internal class SortingComparison
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };

            foreach (int size in sizes)
            {
                Console.WriteLine("\nDataset Size: " + size);

                int[] data = GenerateData(size);

                // Bubble Sort (skip for very large input)
                if (size <= 10000)
                {
                    int[] bubbleData = (int[])data.Clone();
                    Stopwatch sw = Stopwatch.StartNew();
                    BubbleSort(bubbleData);
                    sw.Stop();
                    Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");
                }
                else
                {
                    Console.WriteLine("Bubble Sort Time: Unfeasible");
                }

                // Merge Sort
                int[] mergeData = (int[])data.Clone();
                Stopwatch swMerge = Stopwatch.StartNew();
                MergeSort(mergeData, 0, mergeData.Length - 1);
                swMerge.Stop();
                Console.WriteLine("Merge Sort Time: " + swMerge.ElapsedMilliseconds + " ms");

                // Quick Sort
                int[] quickData = (int[])data.Clone();
                Stopwatch swQuick = Stopwatch.StartNew();
                QuickSort(quickData, 0, quickData.Length - 1);
                swQuick.Stop();
                Console.WriteLine("Quick Sort Time: " + swQuick.ElapsedMilliseconds + " ms");
            }
        }

        static Random Random = new Random();

        static int[] GenerateData(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = Random.Next(1, size);
            return arr;
        }

        // Bubble Sort O(N^2)
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort O(N log N)
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            while (i <= mid && j <= right)
                temp[k++] = arr[i] <= arr[j] ? arr[i++] : arr[j++];

            while (i <= mid)
                temp[k++] = arr[i++];

            while (j <= right)
                temp[k++] = arr[j++];

            for (i = left, k = 0; i <= right; i++, k++)
                arr[i] = temp[k];
        }

        // Quick Sort O(N log N)
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low >= high)
                return;

            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int swap = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swap;

            return i + 1;
        }
    }
}

