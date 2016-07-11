using Mavirea.Command;
using System;

namespace Mavirea.Scene
{
    public interface ISceneManager : IInterlocutor
    {
        void ChangeScene(int id);
    }
}
