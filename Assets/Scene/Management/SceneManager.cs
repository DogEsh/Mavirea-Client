using UnityEngine;
using System;
using System.Collections.Generic;
using Mavirea.Command;
using System.Threading;

namespace Mavirea.Scene
{
    using SM = UnityEngine.SceneManagement.SceneManager;
    using SC = UnityEngine.SceneManagement.Scene;
    using SceneID = Byte;

    public class SceneManager : MonoBehaviour, ISceneManager
    {
        private SC[] _scenes = new SC[(int)HelperSceneID.MaxLength];

        int _id = 0;
        object _syncObj = new object();
        bool _isChanged = false;

        

        void Start()
        {
            //GameObject[] g = sc.GetRootGameObjects();
            //foreach (GameObject gg in g)
            //{
            //  if (gg.name == "Canvas")
            //  {
            //     // Destroy(gg);
            //  }
            // }
        }

        void Update()
        {
            lock (_syncObj)
            {
                if (_isChanged)
                {
                    _isChanged = false;
                    SM.LoadScene(_id);
                    _scenes[_id] = SM.GetActiveScene();
                }
            }
        }

       

        public void ChangeScene(int id)
        {
            lock (_syncObj)
            {
                if(_id != id)
                {
                    _id = id;
                    _isChanged = true;
                }
            }
        }


        static IScenario _scenario = new ScenarioQueue();
        public static IScenario GetScenario()
        {
            return _scenario;
        }
        IScenario IInterlocutor.GetScenario()
        {
            return _scenario;
        }
    }
}

