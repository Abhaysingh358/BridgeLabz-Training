using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class FilterStream
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source image path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter output image path: ");
            string outputFile = Console.ReadLine();

            try
            {
                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (BufferedStream bsRead = new BufferedStream(fsRead))
                using (StreamReader reader = new StreamReader(bsRead, Encoding.UTF8))
                using (FileStream fsWrite = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (BufferedStream bsWrite = new BufferedStream(fsWrite))
                using (StreamWriter writer = new StreamWriter(bsWrite, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.ToLower());
                    }
                }

                Console.WriteLine("File converted to lowercase successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
