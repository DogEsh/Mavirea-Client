using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Message.Handler
{
    using MT = Byte;
    public class AllHandlersMessageList : IAllHandlersMessage
    {
        private List<IHandlerMessage> _handlers; 
        public AllHandlersMessageList(List<IHandlerMessage> handlers)
        {
            _handlers = handlers;
        }
        public bool SetMessage(IMessage message)
        {
            foreach(IHandlerMessage h in _handlers)
            {
                if (h.Type == message.Data.Type)
                {
                    return h.SetMessage(message);
                }
            }
            return false;
        }
    }
}
