using System.IO;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Mavirea.BinarySerialization.DotNet
{


    public class Unpacker : IUnpacker
    {
        IFormatter formatter;
        public Unpacker()
        {
            formatter = new BinaryFormatter();
        }

        public bool Unpack<T>(ref T data, Stream stream)
            where T : class
        {
            try
            {
                data = formatter.Deserialize(stream) as T;
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
