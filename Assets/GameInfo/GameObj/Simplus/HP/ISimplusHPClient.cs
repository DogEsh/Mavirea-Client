﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    public interface ISimplusHPClient : ISimplusHPBase
    {
        void Inc(int HP);
    }
}