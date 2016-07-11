using System;
using System.Collections.Generic;
using Mavirea.Command;
using System.Collections;
using Mavirea.Scene;

namespace Mavirea.Command
{
    public class InterlocutorsList : IInterlocutorsContainer
    {
        protected List<IInterlocutor> _container;
        protected InterlocutorsList()
        {
            _container = new List<IInterlocutor>();
        }
        
        public InterlocutorsList(List<IInterlocutor> container)
        {
            _container = container;
        }
        public DestType GetInterlocutor<DestType>()
            where DestType : class, IInterlocutor
        {
            foreach (IInterlocutor i in _container)
            {
                if (i is DestType)
                {
                    return i as DestType;
                }
            }
            return null;
        }

        public IEnumerator<IInterlocutor> GetEnumerator()
        {
            return _container.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
