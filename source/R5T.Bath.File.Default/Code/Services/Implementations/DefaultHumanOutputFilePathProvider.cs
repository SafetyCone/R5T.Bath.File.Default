using System;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Bath.File.Default
{
    [ServiceImplementationMarker]
    public class DefaultHumanOutputFilePathProvider : IHumanOutputFilePathProvider, IServiceImplementation
    {
        private IHumanOutputFileDirectoryPathProvider HumanOutputFileDirectoryPathProvider { get; }
        private IHumanOutputFileNameProvider HumanOutputFileNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultHumanOutputFilePathProvider(
            IHumanOutputFileDirectoryPathProvider humanOutputFileDirectoryPathProvider,
            IHumanOutputFileNameProvider humanOutputFileNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.HumanOutputFileDirectoryPathProvider = humanOutputFileDirectoryPathProvider;
            this.HumanOutputFileNameProvider = humanOutputFileNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetHumanOutputFilePath()
        {
            var directoryPath = this.HumanOutputFileDirectoryPathProvider.GetHumanOutputFileDirectoryPath();
            var fileName = this.HumanOutputFileNameProvider.GetHumanOutputFileName();

            var filePath = this.StringlyTypedPathOperator.GetFilePath(directoryPath, fileName);
            return filePath;
        }
    }
}
