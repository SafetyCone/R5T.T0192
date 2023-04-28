using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0192
{
    /// <inheritdoc cref="ILocalRunSpecificDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class LocalRunSpecificDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        ILocalRunSpecificDirectoryPath
    {
        public LocalRunSpecificDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
