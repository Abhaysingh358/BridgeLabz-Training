

namespace BridgeLabz.MSTests
{
    [TestClass]
    public class FileProcessorMSTests
    {
        private FileProcessor processor;
        private string testFile;

        [TestInitialize]
        public void Setup()
        {
            processor = new FileProcessor();
            testFile = "testfile.txt";

            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [TestMethod]
        public void WriteAndRead_File_WorksCorrectly()
        {
            processor.WriteToFile(testFile, "Hello MSTest");

            string content = processor.ReadFromFile(testFile);

            Assert.AreEqual("Hello MSTest", content);
        }

        [TestMethod]
        public void WriteToFile_FileExistsAfterWrite()
        {
            processor.WriteToFile(testFile, "Test");

            Assert.IsTrue(File.Exists(testFile));
        }

        [TestMethod]
        public void ReadFromFile_NonExistingFile_ThrowsException()
        {
            Assert.Throws<IOException>(() => processor.ReadFromFile("nofile.txt"));
        }
    }
}
