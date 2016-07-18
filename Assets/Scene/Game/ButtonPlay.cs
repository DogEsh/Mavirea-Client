using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mavirea.Scene.Game
{
    public class ButtonPlay : MonoBehaviour
    {
        public void SwitchButton()
        {
            FinderDisabledGameObject.GetComponentInChildren<ButtonPause>
                (gameObject.transform.parent.gameObject).gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
