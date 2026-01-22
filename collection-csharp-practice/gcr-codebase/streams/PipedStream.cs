using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.collection_csharp_practice.gcr_codebase.streams
{
    class PipedStream
    {
        static void Main(string[] args)
        {
            try
            {
                using (AnonymousPipeServerStream pipeServer =
                       new AnonymousPipeServerStream(PipeDirection.Out))
                using (AnonymousPipeClientStream pipeClient =
                       new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
                {
                    Thread writerThread = new Thread(() => WriteData(pipeServer));
                    Thread readerThread = new Thread(() => ReadData(pipeClient));

                    writerThread.Start();
                    readerThread.Start();

                    writerThread.Join();
                    readerThread.Join();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }

        static void WriteData(Stream pipe)
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8) { AutoFlush = true })
            {
                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine($"Message {i}");
                    Thread.Sleep(500); // simulate work
                }
            }
        }

        static void ReadData(Stream pipe)
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine("Received: " + line);
                }
            }
        }
    }
}
