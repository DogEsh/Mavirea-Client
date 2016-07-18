using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Mavirea.BinarySerialization
{
    class Vector2Surrogate : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, StreamingContext context)
        {
            Vector2 v = (Vector2)obj;
            info.AddValue("x", v.x);
            info.AddValue("y", v.y);
        }

        public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
        {
            Vector2 v = (Vector2)obj;
            v.x = info.GetSingle("x");
            v.y = info.GetSingle("y");
            return v;
        }
    }
}