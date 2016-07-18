using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mavirea.GameInfo
{
    [Serializable]
    public class Party : IParty
    {
        public uint ID { get; set; }
        public bool IsMy(IParty party)
        {
            return ID == party.ID;
        }
        public Party(uint id)
        {
            ID = id;
        }
    }
}
