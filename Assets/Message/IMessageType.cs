using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Message
{
    using MT = Byte;
    public interface IMessageType
    {
        MT Type { get; }
    }
}
