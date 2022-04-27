using System;

using R5T.T0064;


namespace R5T.Bath.File.Default
{
    [ServiceImplementationMarker]
    public class DefaultHumanOutputFileNameProvider : IHumanOutputFileNameProvider, IServiceImplementation
    {
        public const string FileName = "Human Output.txt";


        public string GetHumanOutputFileName()
        {
            return DefaultHumanOutputFileNameProvider.FileName;
        }
    }
}
