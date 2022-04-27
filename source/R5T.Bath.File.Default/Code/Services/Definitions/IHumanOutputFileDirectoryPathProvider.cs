using System;

using R5T.T0064;


namespace R5T.Bath.File.Default
{
    [ServiceDefinitionMarker]
    public interface IHumanOutputFileDirectoryPathProvider : IServiceDefinition
    {
        string GetHumanOutputFileDirectoryPath();
    }
}
