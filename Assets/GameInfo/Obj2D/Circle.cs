﻿using System;
using UnityEngine;

namespace Mavirea.GameInfo
{
    public class Circle : IObj2D
    {
        protected Vector2 _pos;
        protected float _radius;


        public Circle(Vector2 pos, float radius)
        {
            _pos = pos;
            _radius = radius;
        }

        public void SetRadius(float radius)
        {
            _radius = radius;
        }
        public float Radius
        {
            get
            {
                return _radius;
            }
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
            Vector2 v = destination - _pos;
            v = v.normalized;
            return _pos + v*_radius;
        }

        public bool IsFocused(Vector2 pos)
        {
            Vector2 v = pos - _pos;

            if (v.magnitude < _radius)
            {
                return true;
            }
            return false;
        }

        public bool IsFocused(Vector2 pos, ITransformCoordinate tran)
        {
            Vector2 p = tran.TransformPos(_pos);
            p -= pos;
            float r = tran.Size * _radius;
            if (p.magnitude < r)
            {
                return true;
            }
            return false;
        }

        public Vector2 GetPosSurface(Vector2 destination, ITransformCoordinate tran)
        {
            Vector2 p = tran.TransformPos(_pos);
            Vector2 v = destination - p;
            v = v.normalized;
            return p + v * tran.Size*_radius;
        }
    }
}

