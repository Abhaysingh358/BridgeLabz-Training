using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.CustomHashMap
{
        public class HashMapMenu
        {
            public void Run()
            {
                MyHashMap<string, int> map = new MyHashMap<string, int>();
                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n--- Custom Hash Map ---");
                    Console.WriteLine("1. Insert");
                    Console.WriteLine("2. Get");
                    Console.WriteLine("3. Remove");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter key: ");
                                string key = Console.ReadLine();

                                Console.Write("Enter value: ");
                                int value = Convert.ToInt32(Console.ReadLine());

                                map.Put(key, value);

                                Console.WriteLine("Inserted/Updated successfully");
                                break;

                            case 2:
                                Console.Write("Enter key: ");
                                key = Console.ReadLine();
                                Console.WriteLine("Value: " + map.Get(key));
                                break;

                            case 3:
                                Console.Write("Enter key: ");
                                key = Console.ReadLine();
                                map.Remove(key);
                                Console.WriteLine("Key removed successfully");
                                break;

                            case 4:
                                exit = true;
                                break;

                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
}


