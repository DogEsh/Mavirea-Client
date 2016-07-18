using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace Assets.Skin
{
    class SkinFrontSize : MonoBehaviour
    {
        void OnGUI()
        {
            
            //Set the GUIStyle style to be label
            GUIStyle style = GUI.skin.GetStyle("label");

            //Set the style font size to increase and decrease over time
            style.fontSize = (int)(20.0f + 10.0f * Mathf.Sin(Time.time));

            //Create a label and display with the current settings
            GUI.Label(new Rect(10, 10, 200, 80), "Hello World!");
        }
    }
}
