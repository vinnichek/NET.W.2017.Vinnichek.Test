using System;
using System.IO;

namespace Task2.Solution
{
    public class RandomBytesFileGenerator : FileGenerator
    {
        public RandomBytesFileGenerator() : base("Files with random bytes", ".bytes") { }

        protected override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }

        protected override void WriteBytesToFile(string fileName, byte[] content)
        {
            if (Directory.Exists(WorkingDirectory) == false)
            {
                Directory.CreateDirectory(WorkingDirectory);
            }

            File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
        }
    }
}
