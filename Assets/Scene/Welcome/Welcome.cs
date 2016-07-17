using UnityEngine;
using System.Collections;
using Mavirea.Command;
using Mavirea.Scene;

namespace Mavirea.Scene.Welcome
{
    using SM = UnityEngine.SceneManagement.SceneManager;
    using SC = UnityEngine.SceneManagement.Scene;
    public class Welcome : MonoBehaviour
    {
        IScenario _scenario;
        void Start()
        {
            _scenario = SceneManager.GetScenario();
        }

        float _time = 0.5f;
        bool _isExit = false;

        void Update()
        {
            if (_isExit) return;
            _time -= Time.deltaTime;
            if (_time <= 0)
            {
                ICommand cmd = new CommandChangeScene(HelperSceneID.Menu);
                _scenario.SetCommand(cmd);
                _isExit = true;
            }
        }


    }

}
