using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Threading
{
    public interface ISteppable
    {
        bool Step();
        void Destroy();
    }
}
