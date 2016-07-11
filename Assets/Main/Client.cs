using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using Mavirea.Command;
using System;
using Mavirea.Threading;
using Mavirea.Scene;

namespace Mavirea.Main
{
    public class Client : MonoBehaviour, IMain
    {
        bool _isExit = false;
        IThread _scenarioThread;
        void Start()
        {
            DontDestroyOnLoad(this);
            InitScenario();
        }

        private void InitScenario()
        {
            List<IInterlocutor> ii = new List<IInterlocutor>();
            ii.Add(this);
            ii.Add(GetComponent<ISceneManager>());
            
            IInterlocutorsContainer co = new InterlocutorsList(ii);
            ISteppable st = new ScenarioSteppable(co);
            _scenarioThread = new ThreadSleepy(st, 100);
            _scenarioThread.Start();
        }

        void Update()
        {
            if (_isExit == true)
            {
                _scenarioThread.Close();
                Application.Quit();
            }
        }
        public void Exit()
        {
            _isExit = true;
        }

        public IScenario GetScenario()
        {
            return null;
        }
    }
}

