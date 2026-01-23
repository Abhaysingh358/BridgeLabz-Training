using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
    class FileReaderApp
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file name you want to read (Example: data.txt): ");
            string inputFileName = Console.ReadLine();

            try
            {
                string fileContent = File.ReadAllText(inputFileName);

                Console.WriteLine("\n File Content:\n");
                Console.WriteLine(fileContent);
            }
            catch (IOException)
            {
                Console.WriteLine("\nFile not found");
            }
        }
    }

}
