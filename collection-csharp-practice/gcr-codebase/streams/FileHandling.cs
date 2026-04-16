using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class FileHandlingExample
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source file path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter destination file path: ");
            string destinationFile = Console.ReadLine();

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream fsWrite = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    int byteData;
                    while ((byteData = fsRead.ReadByte()) != -1)
                    {
                        fsWrite.WriteByte((byte)byteData);
                    }
                }

                Console.WriteLine("File copied successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
