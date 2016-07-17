using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Message.Handler
{
    public class AllHandlersMessageList : IAllHandlersMessage
    {
        private List<IHandlerMessage> _handlers; 
        public AllHandlersMessageList(List<IHandlerMessage> handlers)
        {
            _handlers = handlers;
        }
        public bool SetMessage(IMessage message)
        {
            
        }
    }
}
