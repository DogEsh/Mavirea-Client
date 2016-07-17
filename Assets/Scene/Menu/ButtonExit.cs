using Mavirea.Command;
using UnityEngine;

namespace Mavirea.Scene.Menu
{
    public class ButtonExit : MonoBehaviour
    {
        public void Exit()
        {
            ICommand cmd = new CommandExit();
            SceneManager.GetScenario().SetCommand(cmd);
        }
    }
}
