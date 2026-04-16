using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Validate
{
    static void Main()
    {
        Console.WriteLine("Enter CSV file path:");
        string filePath = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filePath) || !File.Exists(filePath))
        {
            Console.WriteLine("Invalid file path.");
            return;
        }

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("\nInvalid CSV Rows:\n");

            foreach (string line in lines.Skip(1))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] data = line.Split(',', StringSplitOptions.TrimEntries);

                if (data.Length != 4)
                {
                    Console.WriteLine($"Invalid format : {line}");
                    continue;
                }

                string email = data[2];
                string phone = data[3];

                bool isEmailValid = Regex.IsMatch(email, emailPattern);
                bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                if (!isEmailValid || !isPhoneValid)
                {
                    Console.WriteLine($"Row Error : {line}");

                    if (!isEmailValid)
                        Console.WriteLine("Invalid Email Format");

                    if (!isPhoneValid)
                        Console.WriteLine("Phone must contain exactly 10 digits");

                    Console.WriteLine();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error validating CSV: " + ex.Message);
        }
    }
}
