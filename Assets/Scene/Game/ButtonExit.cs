using UnityEngine;
using Mavirea.Command;
using System.Collections;

namespace Mavirea.Scene.Game
{
    class ButtonExit : MonoBehaviour
    {
        public void ExitGame()
        {
            ICommand cmd = new CommandChangeScene(HelperSceneID.Menu);
            SceneManager.GetScenario().SetCommand(cmd);
        }
    }
}