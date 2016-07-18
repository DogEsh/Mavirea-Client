using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    public interface ISimplusHP 
    {
        bool Inc(int HP, bool isCapture);
        int Cur { get; }
        int Max { get; }
    }
}
