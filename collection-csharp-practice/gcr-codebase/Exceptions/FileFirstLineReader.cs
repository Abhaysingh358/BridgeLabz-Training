using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.Exceptions
{
  
    class FileFirstLineReaderApp
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader fileReader = new StreamReader("info.txt"))
                {
                    string firstLine = fileReader.ReadLine();
                    Console.WriteLine("First Line: " + firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }

}
