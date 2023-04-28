using System;

using R5T.T0178;
using R5T.T0189;
using R5T.T0190;


namespace R5T.T0192
{
    /// <summary>
    /// Strongly-types a string as the path of a local run-specific directory.
    /// </summary>
    [StrongTypeMarker]
    public interface ILocalRunSpecificDirectoryPath : IStrongTypeMarker,
        ILocalDirectoryPath,
        IRunSpecificDirectoryPath
    {
    }
}
