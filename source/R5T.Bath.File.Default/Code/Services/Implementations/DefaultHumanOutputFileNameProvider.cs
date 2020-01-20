using System;


namespace R5T.Bath.File.Default
{
    public class DefaultHumanOutputFileNameProvider : IHumanOutputFileNameProvider
    {
        public const string FileName = "Human Output.txt";


        public string GetHumanOutputFileName()
        {
            return DefaultHumanOutputFileNameProvider.FileName;
        }
    }
}
