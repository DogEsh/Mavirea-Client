using System.Collections.Generic;
using System;

namespace Mavirea.GameInfo
{
    using GameID = UInt16;
    public interface ILinkInfoContainer : IGameObjContainer<ISimplusLinkInfo>
    {
        int MaxCount { get; }
    }
}
