using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Message.Handler
{
    public interface IAllHandlersMessage
    {
        bool SetMessage(IMessage message);
    }
}
