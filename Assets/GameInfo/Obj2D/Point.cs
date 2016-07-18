﻿using System;
using UnityEngine;

namespace Mavirea.GameInfo
{
    [Serializable]
    public class Point : IObj2D
    {
        private Vector2 _pos;
        public Point(Vector2 pos)
        {
            _pos = pos;
        }

        public Vector2 Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos = value;
            }
        }

        public Vector2 GetPosSurface(Vector2 destination)
        {
            return _pos;
        }

        public Vector2 GetPosSurface(Vector2 destination, ITransformCoordinate tran)
        {
            return tran.TransformPos(_pos);
        }

        public bool IsFocused(Vector2 pos)
        {
            return pos.Equals(_pos);
        }

        public bool IsFocused(Vector2 pos, ITransformCoordinate tran)
        {
            Vector2 p = tran.TransformPos(_pos);
            return pos.Equals(p);
        }
    }
}
