using System.IO;
using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mavirea.BinarySerialization
{
    public class Packer : IPacker
    {
        IFormatter formatter;
        public Packer()
        {
            formatter = new BinaryFormatter();
        }



        public bool Pack<T>(ref Stream stream, T data)
            where T : class
        {
            try
            {
                formatter.Serialize(stream, data);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
