using System;

using R5T.T0064;


namespace R5T.Bath.File.Default
{
    [ServiceDefinitionMarker]
    public interface IHumanOutputFileNameProvider : IServiceDefinition
    {
        string GetHumanOutputFileName();
    }
}
