using System;
using ContactAppH2Database.Models;
using ContactAppH2Database.Repository;

namespace ContactAppH2Database
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var repo = new ContactRepository();
            repo.InitializeDatabase();

            // Simple manual test / menu loop
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n--- Contact App ---");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. List Contacts");
                Console.WriteLine("3. Get Contact by Id");
                Console.WriteLine("4. Update Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Name: ");
                        var name = Console.ReadLine();
                        Console.Write("Email: ");
                        var email = Console.ReadLine();
                        Console.Write("Phone: ");
                        var phone = Console.ReadLine();
                        repo.Add(new Contact { Name = name, Email = email, Phone = phone });
                        Console.WriteLine("Contact added.");
                        break;

                    case "2":
                        var all = repo.GetAll();
                        foreach (var c in all)
                            Console.WriteLine($"{c.Id}: {c.Name}, {c.Email}, {c.Phone}");
                        break;

                    case "3":
                        Console.Write("Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var found = repo.GetById(id);
                        Console.WriteLine(found != null
                            ? $"{found.Id}: {found.Name}, {found.Email}, {found.Phone}"
                            : "Not found.");
                        break;

                    case "4":
                        Console.Write("Id to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("New Name: ");
                        var newName = Console.ReadLine();
                        Console.Write("New Email: ");
                        var newEmail = Console.ReadLine();
                        Console.Write("New Phone: ");
                        var newPhone = Console.ReadLine();
                        repo.Update(new Contact { Id = updateId, Name = newName, Email = newEmail, Phone = newPhone });
                        Console.WriteLine("Contact updated.");
                        break;

                    case "5":
                        Console.Write("Id to delete: ");
                        int delId = Convert.ToInt32(Console.ReadLine());
                        repo.Delete(delId);
                        Console.WriteLine("Contact deleted.");
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}