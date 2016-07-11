using Mavirea.Main;

namespace Mavirea.Command
{
    class CommandExit : ICommand
    {
        public bool Do(IInterlocutorsContainer interlocutors)
        {
            IMain i = interlocutors.GetInterlocutor<IMain>();
            if (i == null) return false;

            i.Exit();
            return true;
        }
    }
}
