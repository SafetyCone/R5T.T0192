using System;


namespace R5T.T0192.Extensions
{
    public static class StringExtensions
    {
        public static ILocalRunSpecificDirectoryPath ToLocalRunSpecificDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLocalRunSpecificDirectoryPath(value);
        }
    }
}
