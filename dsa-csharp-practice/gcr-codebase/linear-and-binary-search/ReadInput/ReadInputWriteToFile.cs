using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.ReadInput
{
    internal class ReadInputWriteToFile
    {
       
            public void WriteUserInputToFile()
            {
                Console.Write("Enter file path to write (example: D:\\\\userInput.txt): ");
                string path = Console.ReadLine();

                try
                {
                    // StreamReader to read from Console input stream
                    StreamReader reader = new StreamReader(Console.OpenStandardInput());

                    // StreamWriter to write into file
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        Console.WriteLine("\nType anything to save into file.");
                        Console.WriteLine("Type 'exit' to stop writing.\n");

                        while (true)
                        {
                            Console.Write("Enter Input: ");
                            string input = reader.ReadLine(); // reads full line

                            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("\nWriting stopped!");
                                break;
                            }

                            writer.WriteLine(input); // writing line to file
                        }
                    }

                    Console.WriteLine("Data saved successfully into file!");
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

