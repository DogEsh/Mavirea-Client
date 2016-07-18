using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Skin
{
    class SkinTest : MonoBehaviour
    {
        GUISkin _skin;
        void Start()
        {
            _skin = Resources.Load<GUISkin>("GUISkin");
        }
        void OnGUI()
        {
            GUI.skin = _skin;
        }
    }
}
