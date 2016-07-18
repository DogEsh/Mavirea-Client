using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mavirea.Message;
using Mavirea.Message.Handler;

namespace Mavirea.Scene.Menu
{
    public class SceneMenu : IScene
    {
        IAllHandlersMessage _handlers;
        public SceneMenu()
        {
            List<IHandlerMessage> h = new List<IHandlerMessage>();
            _handlers = new AllHandlersMessageList(h);
        }
        public bool SetMessage(IMessage message)
        {
            return _handlers.SetMessage(message);
        }
    }
}
