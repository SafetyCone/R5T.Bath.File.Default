using System;

using R5T.Lombardy;


namespace R5T.Bath.File
{
    public class DefaultHumanOutputFilePathProvider : IHumanOutputFilePathProvider
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
