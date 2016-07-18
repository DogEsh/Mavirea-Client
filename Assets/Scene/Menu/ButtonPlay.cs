using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Mavirea.Command;

namespace Mavirea.Scene.Menu
{
    class ButtonPlay : MonoBehaviour
    {
        public void PlayGame()
        {
            gameObject.GetComponent<AudioSource>().Play();
            ICommand cmd = new CommandChangeScene(HelperSceneID.Game);
            SceneManager.GetScenario().SetCommand(cmd);
        }
        //public void NNN()
        //{
        //    transform.GetComponent<Button>().interactable = false;
        //}
    }
}
