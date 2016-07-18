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
            FinderDisabledGameObject.GetComponentInChildren<ButtonPlay>
                (gameObject.transform.parent.gameObject).gameObject.SetActive(true);
            gameObject.SetActive(false);           
        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}

