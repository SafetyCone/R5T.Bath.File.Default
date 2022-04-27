using System;

using R5T.T0064;


namespace R5T.Bath.File.Default
{
    [ServiceImplementationMarker]
    public class SpecifiedHumanOutputFileDirectoryPathProvider : IHumanOutputFileDirectoryPathProvider, IServiceImplementation
    {
        private string HumanOutputFileDirectoryPath { get; }


        public SpecifiedHumanOutputFileDirectoryPathProvider(
            [NotServiceComponent] string humanOutputFileDirectoryPath)
        {
            this.HumanOutputFileDirectoryPath = humanOutputFileDirectoryPath;
        }

        public string GetHumanOutputFileDirectoryPath()
        {
            return this.HumanOutputFileDirectoryPath;
        }
    }
}
