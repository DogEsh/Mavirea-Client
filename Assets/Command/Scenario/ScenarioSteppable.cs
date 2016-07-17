using System.Collections.Generic;
using System.Threading;
using Mavirea.Command;
using Mavirea.Threading;
using System;

namespace Mavirea.Command
{
    /**
    *<summary>
    Исполняет сценарии, вызывая по очереди команды.
    <para/>
    Для того чтобы он исполнял сценарий, ему надо его добавить.
    <para/>
    Хранит все необходимые параметры для исполнения команд.
    </summary>
    */
    public class ScenarioSteppable : ISteppable
    {
        IInterlocutorsContainer _interlocutors;

        public ScenarioSteppable(IInterlocutorsContainer interlocutors)
        {
            _interlocutors = interlocutors;
        }

        public bool Step()
        {
            foreach (IInterlocutor i in _interlocutors)
            {
                IScenario s = i.GetScenario();
                while (s != null)
                {
                    ICommand c = s.GetCommand();
                    if (c == null) break;
                    c.Do(_interlocutors);
                }
            }
            return true;
        }
        public void Destroy()
        { 
        }
    }
}
