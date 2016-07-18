using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mavirea.Command;

namespace Mavirea.Scene.Menu
{
    class ButtonExit : MonoBehaviour
    {
        public void ExitGame()
        {
            ICommand cmd = new CommandExit();
            SceneManager.GetScenario().SetCommand(cmd);
        }
    }
}
