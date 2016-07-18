using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    public interface ISimplusInfoClient : ISimplusInfoBase
    {
        void IncHP(int HP, ISimplusInfo source);
    }
}
