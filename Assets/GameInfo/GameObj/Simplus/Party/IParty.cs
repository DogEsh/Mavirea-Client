using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    public interface IParty
    {
        uint ID { get; set; }
        bool IsMy(IParty party);
    }
}
