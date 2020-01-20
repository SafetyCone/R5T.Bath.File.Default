using System;


namespace R5T.Bath.File.Default
{
    public class SpecifiedHumanOutputFileDirectoryPathProvider : IHumanOutputFileDirectoryPathProvider
    {
        private string HumanOutputFileDirectoryPath { get; }


        public SpecifiedHumanOutputFileDirectoryPathProvider(string humanOutputFileDirectoryPath)
        {
            this.HumanOutputFileDirectoryPath = humanOutputFileDirectoryPath;
        }

        public string GetHumanOutputFileDirectoryPath()
        {
            return this.HumanOutputFileDirectoryPath;
        }
    }
}
