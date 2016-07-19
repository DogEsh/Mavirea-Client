using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Mavirea.Scene.GameObjectHelper;

namespace Mavirea.Scene.Game
{
    public class ButtonPlay : MonoBehaviour
    {
        public void SwitchButton()
        {
            Finder.GetComponentInChildren<ButtonPause>
                (gameObject.transform.parent.gameObject).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
