using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.csharp_sorting
{
    // JobApplicant class
    class JobApplicant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ExpectedSalary { get; set; }
        public JobApplicant(int id, string name, double expectedSalary)
        {
            Id = id;
            Name = name;
            ExpectedSalary = expectedSalary;
        }
        public override string ToString()
        {
            return "Id: " + Id + "\nName: " + Name + "\nExpected Salary: " + ExpectedSalary;
        }
    }
    internal class ArrangeApplicantBySalary
    {
        static void HeapSortBySalary(JobApplicant[] applicants)
        {
            int n = applicants.Length;

            // build max heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(applicants, n, i);
            }
            // extract elements one by one
            for (int i = n - 1; i > 0; i--)
            {
                JobApplicant temp = applicants[0];
                applicants[0] = applicants[i];
                applicants[i] = temp;

                Heapify(applicants, i, 0);
            }
        }

        static void Heapify(JobApplicant[] applicants, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && applicants[left].ExpectedSalary > applicants[largest].ExpectedSalary)
                largest = left;

            if (right < n && applicants[right].ExpectedSalary > applicants[largest].ExpectedSalary)
                largest = right;

            if (largest != i)
            {
                JobApplicant swap = applicants[i];
                applicants[i] = applicants[largest];
                applicants[largest] = swap;

                Heapify(applicants, n, largest);
            }
        }
        static void Main(string[] args)
        {
            JobApplicant[] applicants = new JobApplicant[5];

            for (int i = 0; i < applicants.Length; i++)
            {
                int id = Convert.ToInt32(Console.ReadLine());
                string name = Console.ReadLine();
                double salary = Convert.ToDouble(Console.ReadLine());
                applicants[i] = new JobApplicant(id, name, salary);
            }
            Console.WriteLine("\nBefore Sorting");
            for (int i = 0; i < applicants.Length; i++)
            {
                Console.WriteLine(applicants[i]);
            }

            HeapSortBySalary(applicants);

            Console.WriteLine("\nAfter Sorting");
            for (int i = 0; i < applicants.Length; i++)
            {
                Console.WriteLine(applicants[i]);
            }
        }
    }
}

