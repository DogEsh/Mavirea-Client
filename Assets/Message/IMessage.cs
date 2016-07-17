using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Message
{
    public interface IMessage
    {
        IMessageAddress Address { get; }
        IMessageData Data { get; }
    }
}
