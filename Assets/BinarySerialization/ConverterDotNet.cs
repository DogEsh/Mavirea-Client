using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Mavirea.BinarySerialization
{
    public class ConverterDotNet : IConverter
    {
        IFormatter formatter;
        public ConverterDotNet()
        {
            formatter = new BinaryFormatter();
            var surrogateSelector = new SurrogateSelector();
            surrogateSelector.AddSurrogate(typeof(Vector2), new StreamingContext(StreamingContextStates.All),
                                               new Vector2Surrogate());
            formatter.SurrogateSelector = surrogateSelector;
        }

        public bool Unpack<T>(ref T data, Stream stream)
            where T : class
        {
            try
            {
                data = formatter.Deserialize(stream) as T;
            }
            catch (Exception ex)
            {
                Debug.Log(ex.ToString());
                return false;
            }
            return true;
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
                Debug.Log(ex.ToString());
                return false;
            }
            return true;
        }
    }
}
