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
            GameObject par = gameObject.transform.parent.gameObject;
            ButtonPause p = par.GetComponentInChildren<ButtonPause>();
            GameObject g = p.gameObject;
            g.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
