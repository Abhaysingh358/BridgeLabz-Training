using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name;
    public string Email;
    public double Salary;
}

class Program
{
    static void Main()
    {
        Console.Write("Enter secret key for encryption/decryption: ");
        string secretKey = Console.ReadLine();

        Console.Write("Enter CSV file path to create: ");
        string csvPath = Console.ReadLine();

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Rahul", Email = "rahul@gmail.com", Salary = 60000 },
            new Employee { Id = 2, Name = "Anita", Email = "anita@gmail.com", Salary = 55000 }
        };

        WriteEncryptedCsv(csvPath, employees, secretKey);
        ReadDecryptedCsv(csvPath, secretKey);
    }

    static void WriteEncryptedCsv(string path, List<Employee> employees, string key)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Id,Name,Email,Salary");

            foreach (Employee emp in employees)
            {
                string encEmail = Encrypt(emp.Email, key);
                string encSalary = Encrypt(emp.Salary.ToString(), key);

                writer.WriteLine($"{emp.Id},{emp.Name},{encEmail},{encSalary}");
            }
        }

        Console.WriteLine("\nEncrypted CSV written successfully!");
    }

    static void ReadDecryptedCsv(string path, string key)
    {
        using (StreamReader reader = new StreamReader(path))
        {
            reader.ReadLine(); // skip header
            string line;

            Console.WriteLine("\nDecrypted CSV Data:\n");

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                string email = Decrypt(data[2], key);
                double salary = double.Parse(Decrypt(data[3], key));

                Console.WriteLine(
                    $"ID: {data[0]}, Name: {data[1]}, Email: {email}, Salary: {salary}");
            }
        }
    }

    static string Encrypt(string plainText, string key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32));
            aes.IV = new byte[16];

            ICryptoTransform encryptor = aes.CreateEncryptor();
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);

            return Convert.ToBase64String(
                encryptor.TransformFinalBlock(bytes, 0, bytes.Length));
        }
    }

    static string Decrypt(string cipherText, string key)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32));
            aes.IV = new byte[16];

            ICryptoTransform decryptor = aes.CreateDecryptor();
            byte[] bytes = Convert.FromBase64String(cipherText);

            return Encoding.UTF8.GetString(
                decryptor.TransformFinalBlock(bytes, 0, bytes.Length));
        }
    }
}
