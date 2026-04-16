using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.linear_and_binary_search.ByteTOCharacter
{
    internal class ByteToCharacterStream
    {
        public void ReadBinaryAsText()
        {
            Console.Write("Enter file path (binary/text file): ");
            string path = Console.ReadLine();

            if (!File.Exists(path))
            {
                Console.WriteLine("File not found!");
                return;
            }

            try
            {
                // this is step 1: opening the file as a byte swtream
                using (FileStream fs = new FileStream(path , FileMode.Open , FileAccess.Read))
                {
                    // now stream reader will convert the byte file in to chaqr file

                    using(StreamReader sr =new StreamReader(fs, Encoding.UTF8))
                    {

                        Console.WriteLine("Reading file as character");
                        int character;
                        while((character =sr.Read()) != -1)
                        {
                            Console.Write((char)character);
                        }

                        Console.WriteLine("Reading is Done");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
