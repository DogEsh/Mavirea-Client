using UnityEngine;
using System.Collections;
using Mavirea.Scene.GameObjectHelper;



namespace Mavirea.Scene.Game
{
    public class ButtonPause : MonoBehaviour, ISwitcherButton
    {
        ISwitcherButton _swtitcher;
        // Use this for initialization
        void Start()
        {
            GameObject g2 = Finder.GetComponentInChildren<ButtonPlay>
                (gameObject.transform.parent.gameObject).gameObject;

            _swtitcher = new SwitcherButton(gameObject, g2);
        }
        public void SwitchButton()
        {
            _swtitcher.SwitchButton();   
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

