using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

namespace Mavirea.GameInfo
{
    using GameID = UInt16;
    public interface IMapInfo
    {
        ITransformCoordinate Coordinate { get; }
        IGameObjContainer<ISimplusInfo> GetContainerSimplus();
    }
}
