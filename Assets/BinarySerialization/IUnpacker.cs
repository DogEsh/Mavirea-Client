using System;
using System.IO;

namespace Mavirea.BinarySerialization
{
    public enum UnpackerState : byte
    {
        Ok = 0,
        NotReady = 1,
        NotFoundType = 2,
        SizeOut = 3,
        NotParse = 4
    }
    public interface IUnpacker
    {
        bool Unpack<T>(ref T data, Stream stream)
            where T : class;
    }
}
