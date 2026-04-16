using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class BufferedStreams
    {
        const int BufferSize = 4096; // 4 KB

        static void Main(String[] args)
        {
            Console.Write("Enter source file path: ");
            string sourceFile = Console.ReadLine();

            Console.Write("Enter destination file for unbuffered copy: ");
            string destUnbuffered = Console.ReadLine();

            Console.Write("Enter destination file for buffered copy: ");
            string destBuffered = Console.ReadLine();

            // Unbuffered copy
            Stopwatch sw1 = Stopwatch.StartNew();
            CopyWithoutBuffer(sourceFile, destUnbuffered);
            sw1.Stop();
            Console.WriteLine($"Unbuffered copy time: {sw1.ElapsedMilliseconds} ms");

            // Buffered copy
            Stopwatch sw2 = Stopwatch.StartNew();
            CopyWithBuffer(sourceFile, destBuffered);
            sw2.Stop();
            Console.WriteLine($"Buffered copy time: {sw2.ElapsedMilliseconds} ms");
        }

        // Normal FileStream (Unbuffered)
        static void CopyWithoutBuffer(string source, string dest)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[BufferSize];
                int bytesRead;

                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }

        // BufferedStream (Buffered)
        static void CopyWithBuffer(string source, string dest)
        {
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (BufferedStream bsRead = new BufferedStream(fsRead, BufferSize))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite, BufferSize))
            {
                byte[] buffer = new byte[BufferSize];
                int bytesRead;

                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }
    }
}
