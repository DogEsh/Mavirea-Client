using System;
using System.IO;

namespace Mavirea.BinarySerialization
{
    public interface IPacker
    {
        bool Pack<T>(ref Stream stream, T data)
            where T : class;
    }
}
