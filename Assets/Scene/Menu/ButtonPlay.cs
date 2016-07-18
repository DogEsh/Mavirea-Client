using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mavirea.Command;

namespace Mavirea.Scene.Menu
{
    class ButtonPlay : MonoBehaviour
    {
        public void PlayGame()
        {
            ICommand cmd = new CommandChangeScene(HelperSceneID.Game);
            SceneManager.GetScenario().SetCommand(cmd);
        }
    }
}
