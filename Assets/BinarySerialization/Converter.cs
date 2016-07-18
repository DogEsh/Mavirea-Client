using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Mavirea.BinarySerialization
{
    public class Converter : IConverter
    {
        private IUnpacker _unpacker;
        private IPacker _packer;
        public Converter(IPacker packer, IUnpacker unpacker)
        {
            _unpacker = unpacker;
            _packer = packer;
        }

        public bool Unpack<T>(ref T data, Stream stream) where T : class
        {
            return _unpacker.Unpack(ref data, stream);
        }

        public bool Pack<T>(ref Stream stream, T data) where T : class
        {
            return _packer.Pack(ref stream, data);
        }
    }
}
