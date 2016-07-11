using System.Collections.Generic;


namespace Mavirea.Command
{
    /**
    <summary>
    Сценарий отвечает за хранение и очередь исполнения команд.
    </summary>
    */
    public class ScenarioQueue : IScenario
    {
        private Queue<ICommand> _commands;
        public ScenarioQueue()
        {
            _commands = new Queue<ICommand>();
        }
        public ICommand GetCommand()
        {
            ICommand c;
            lock (_commands)
            {
                if (_commands.Count == 0) c = null;
                else c = _commands.Dequeue();
            }
            return c;
        }

        public void SetCommand(ICommand command)
        {
            lock (_commands)
            {
                _commands.Enqueue(command);
            }
        }
    }
}
