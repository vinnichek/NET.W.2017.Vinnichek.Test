using System;
namespace Task2.Solution
{
    public abstract class FileGenerator
    {
        private readonly string workingDirectory;
        private readonly string fileExtension;

        protected FileGenerator(string workingDirectory, string fileExtension)
        {
            this.workingDirectory = workingDirectory;
            this.fileExtension = fileExtension;
        }

        public string WorkingDirectory => workingDirectory;
        public string FileExtension => fileExtension;

        public void GenerateFiles(int filesCount, int contentLength)
        {
            for (var i = 0; i < filesCount; ++i)
            {
                var generatedFileContent = this.GenerateFileContent(contentLength);
                var generatedFileName = $"{Guid.NewGuid()}{this.FileExtension}";

                this.WriteBytesToFile(generatedFileName, generatedFileContent);
            }
        }

        protected abstract byte[] GenerateFileContent(int contentLength);
        protected abstract void WriteBytesToFile(string fileName, byte[] content);

    }
}
