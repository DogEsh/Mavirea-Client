using System;
using Mavirea.Scene;

namespace Mavirea.Command
{
    public class CommandChangeScene : ICommand
    {
        HelperSceneID _id;
        public CommandChangeScene(HelperSceneID id)
        {
            _id = id;
        }
        public bool Do(IInterlocutorsContainer interlocutors)
        {
            ISceneManager i = interlocutors.GetInterlocutor<ISceneManager>();
            if (i == null) return false;

            i.ChangeScene((int)_id);
            return true;
        }
    }
}
