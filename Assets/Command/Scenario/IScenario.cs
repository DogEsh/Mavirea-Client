

namespace Mavirea.Command
{
    public interface IScenario
    {
        ICommand GetCommand();
        void SetCommand(ICommand command);
    }
}