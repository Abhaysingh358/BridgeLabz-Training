using UnitTesting;

namespace BridgeLabz.NUnitTests
{
    public class FileProcessorNUnitTests
    {
        private FileProcessor processor;
        private string testFile;

        [SetUp]
        public void Setup()
        {
            processor = new FileProcessor();
            testFile = "testfile.txt";

            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [Test]
        public void WriteAndRead_File_WorksCorrectly()
        {
            processor.WriteToFile(testFile, "Hello NUnit");

            string content = processor.ReadFromFile(testFile);

            Assert.AreEqual("Hello NUnit", content);
        }

        [Test]
        public void WriteToFile_FileExistsAfterWrite()
        {
            processor.WriteToFile(testFile, "Test");

            Assert.IsTrue(File.Exists(testFile));
        }

        [Test]
        public void ReadFromFile_NonExistingFile_ThrowsException()
        {
            Assert.Throws<IOException>(() => processor.ReadFromFile("nofile.txt"));
        }
    }
}
