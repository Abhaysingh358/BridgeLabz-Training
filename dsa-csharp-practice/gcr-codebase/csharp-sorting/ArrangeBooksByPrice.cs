using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_sorting
{
    // Book class
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Book(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
        public override string ToString()
        {
            return "Book Id: " + Id + "\nTitle: " + Title + "\nPrice: " + Price;
        }
    }

    internal class ArrangeBooksByPrice
    {
        // Merge Sort method
        static void MergeSort(Book[] books, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(books, left, mid);
                MergeSort(books, mid + 1, right);
                Merge(books, left, mid, right);
            }
        }

        static void Merge(Book[] books, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            Book[] L = new Book[n1];
            Book[] R = new Book[n2];

            for (int i = 0; i < n1; i++)
                L[i] = books[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = books[mid + 1 + j];

            int iIndex = 0, jIndex = 0;
            int k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex].Price <= R[jIndex].Price)
                {
                    books[k] = L[iIndex];
                    iIndex++;
                }
                else
                {
                    books[k] = R[jIndex];
                    jIndex++;
                }
                k++;
            }
            while (iIndex < n1)
            {
                books[k] = L[iIndex];
                iIndex++;
                k++;
            }
            while (jIndex < n2)
            {
                books[k] = R[jIndex];
                jIndex++;
                k++;
            }
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[5];

            // taking input from user
            for (int i = 0; i < books.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());     
                string title = Console.ReadLine();                
                double price = Convert.ToDouble(Console.ReadLine()); 
                books[i] = new Book(id, title, price);
            }
            Console.WriteLine("\nBefore Sorting");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
            // calling merge sort
            MergeSort(books, 0, books.Length - 1);

            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]); 
            }
        }
    }
}

