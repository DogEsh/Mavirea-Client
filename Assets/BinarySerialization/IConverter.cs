using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    public interface IConverter
    {
        
        bool Pack<T>(ref Stream stream, T data)
            where T : class;

        bool Unpack<T>(ref T data, Stream stream)
            where T : class;
     }
}
