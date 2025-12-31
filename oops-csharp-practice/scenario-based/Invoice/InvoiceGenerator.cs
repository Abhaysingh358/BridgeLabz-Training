using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class InvoiceGenerator
    {
        // method to split the input text into separate tasks
        static string[] ParseInvoice(string input)
        {
            string[] tasks = input.Split(",");
            return tasks;
        }

        // created method to calculate the total amount from all tasks
        static int GetTotalAmount(string[] tasks)
        {
            int total = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                string cleanTask = tasks[i].Trim();
                string[] taskParts = cleanTask.Split(" - ");
                string[] amountParts = taskParts[1].Split(" ");
                int amount = Convert.ToInt32(amountParts[0]);
                total += amount;
            }

            return total;
        }

        // method containing the menu system
        static void Menu()
        {
            string input = "";
            string[] tasks = null;
            int total = 0;

            Console.WriteLine("Invoice Generator");

            while (true)
            {
                Console.WriteLine("\n1. Create a New Invoice");
                Console.WriteLine("2. Generate Total Bill");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter services like:");
                        Console.WriteLine("\"Logo Design - 3000 INR, Web Page - 4500 INR\"");
                        input = Console.ReadLine();

                        // calling method to split input into tasks
                        tasks = ParseInvoice(input);

                        // calling method to calculate total
                        total = GetTotalAmount(tasks);

                        Console.WriteLine("\nInvoice saved successfully!");
                        continue;

                    case 2:
                        if (tasks == null)
                        {
                            Console.WriteLine("No invoice created yet!");
                            continue;
                        }

                        Console.WriteLine("\n--- SERVICES SELECTED ---");
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            Console.WriteLine(tasks[i].Trim());
                        }

                        Console.WriteLine($"\nTotal Amount: {total} INR\n");
                        continue;

                    case 3:
                        Console.WriteLine("Exiting Invoice Generator...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        // this main method that only calls the Menu() and calls above programm
        static void Main(string[] args)
        {
            Menu();   // calling the menu method
        }
    }

