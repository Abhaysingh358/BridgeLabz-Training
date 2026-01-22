using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class ByteArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter source image path: ");
            string sourceImage = Console.ReadLine();

            Console.Write("Enter output image path: ");
            string outputImage = Console.ReadLine();

            try
            {
                // Read image file into byte array
                byte[] imageBytes = File.ReadAllBytes(sourceImage);

                // Write byte array to new image using MemoryStream
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    File.WriteAllBytes(outputImage, ms.ToArray());
                }

                Console.WriteLine("Image successfully converted to byte array and restored.");

                // Verification
                bool isSame = File.ReadAllBytes(sourceImage).Length == File.ReadAllBytes(outputImage).Length;

                Console.WriteLine(isSame? "Verification successful: Files are identical." : "Verification failed: Files are different.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
