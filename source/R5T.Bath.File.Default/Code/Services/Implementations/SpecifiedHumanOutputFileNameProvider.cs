using System;

using R5T.T0064;


namespace R5T.Bath.File.Default
{
    [ServiceImplementationMarker]
    public class SpecifiedHumanOutputFileNameProvider : IHumanOutputFileNameProvider, IServiceImplementation
    {
        private string HumanOutputFileName { get; }


        public SpecifiedHumanOutputFileNameProvider(
            [NotServiceComponent] string humanOutputFileName)
        {
            this.HumanOutputFileName = humanOutputFileName;
        }

        public string GetHumanOutputFileName()
        {
            return this.HumanOutputFileName;
        }
    }
}
