using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace Mavirea
{
    public class SceneLoader : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            DontDestroyOnLoad(this);
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void LoadMenu()
        {
            SceneManager.LoadScene("Scene/Menu");
        }
        public void LoadGame()
        {
            SceneManager.LoadScene("Scene/Game");
        }
    }

}
