using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mavirea.Command;

namespace Mavirea.Scene.Menu
{
    class GUIMenu : MonoBehaviour
    {
        private IScenario _scenario;
        private void Start()
        {
            _scenario = SceneManager.GetScenario();
        }
        public void PlayGame()
        {
            ICommand cmd = new CommandChangeScene(HelperSceneID.Game);
            SceneManager.GetScenario().SetCommand(cmd);
        }
        public void ExitGame()
        {
            ICommand cmd = new CommandExit();
            SceneManager.GetScenario().SetCommand(cmd);
        }
    }
}
