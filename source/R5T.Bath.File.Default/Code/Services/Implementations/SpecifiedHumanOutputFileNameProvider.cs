using System;


namespace R5T.Bath.File.Default
{
    public class SpecifiedHumanOutputFileNameProvider : IHumanOutputFileNameProvider
    {
        private string HumanOutputFileName { get; }


        public SpecifiedHumanOutputFileNameProvider(string humanOutputFileName)
        {
            this.HumanOutputFileName = humanOutputFileName;
        }

        public string GetHumanOutputFileName()
        {
            return this.HumanOutputFileName;
        }
    }
}
