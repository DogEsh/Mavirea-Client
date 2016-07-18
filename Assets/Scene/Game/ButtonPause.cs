using UnityEngine;
using System.Collections;

namespace Mavirea.Scene.Game
{
    public class ButtonPause : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
        }
        public void SwitchButton()
        {
            GameObject par = gameObject.transform.parent.gameObject;
            ButtonPlay p = par.GetComponentInChildren<ButtonPlay>();
            GameObject g = p.gameObject;
            g.SetActive(true);
            gameObject.SetActive(false);
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

