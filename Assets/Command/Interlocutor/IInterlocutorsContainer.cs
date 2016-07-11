using System.Collections.Generic;
using Mavirea.Command;
using System;

namespace Mavirea.Command
{
    using ParameterID = Byte;
    public interface IInterlocutorsContainer : IEnumerable<IInterlocutor>
    {
        DestType GetInterlocutor<DestType>()
            where DestType : class, IInterlocutor;
    }
}
