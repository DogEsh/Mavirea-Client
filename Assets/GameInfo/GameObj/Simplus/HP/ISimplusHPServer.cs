using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    public interface ISimplusHPServer : ISimplusHPBase
    {
        bool Attack(int HP);
        void Defense(int HP);
    }
}
