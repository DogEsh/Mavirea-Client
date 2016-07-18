using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    using GameID = UInt16;
    public interface IGameObjID
    {
        GameID ID { get; }
    }
}
