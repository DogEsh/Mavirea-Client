using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mavirea.Message;
using Mavirea.Message.Handler;

namespace Mavirea.Scene.Menu
{
    public class HandlerMessageNone : IHandlerMessage
    {
        public byte Type
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool SetMessage(IMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
