using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mavirea.Message;

namespace Mavirea.Scene
{
    public interface IScene
    {
        bool SetMessage(IMessage message);
    }
}
