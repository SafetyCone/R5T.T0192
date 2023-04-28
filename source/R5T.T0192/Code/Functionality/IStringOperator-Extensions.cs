using System;

using R5T.T0132;


namespace R5T.T0192.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public ILocalRunSpecificDirectoryPath ToLocalRunSpecificDirectoryPath(string value)
        {
            var output = new LocalRunSpecificDirectoryPath(value);
            return output;
        }
    }
}
