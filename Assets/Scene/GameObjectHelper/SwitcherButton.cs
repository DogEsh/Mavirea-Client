using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mavirea.Scene.GameObjectHelper
{
    public class SwitcherButton : ISwitcherButton
    {

        GameObject _b1;
        GameObject _b2;
        public SwitcherButton(GameObject b1, GameObject b2)
        {
            _b1 = b1;
            _b2 = b2;
        }
        public void SwitchButton()
        {
            _b1.SetActive(!_b1.activeSelf);
            _b2.SetActive(!_b2.activeSelf);
        }
    }
}
