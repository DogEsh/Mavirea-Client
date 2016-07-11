using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.Threading
{
    public interface IThread
    {
        void Start();
        void Close();
        ISteppable Stop();
        //void Pause();
    }
}
