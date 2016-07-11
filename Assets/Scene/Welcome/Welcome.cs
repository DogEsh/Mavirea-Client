using UnityEngine;
using System.Collections;
using Mavirea.Command;
using Mavirea.Scene;

public class Welcome : MonoBehaviour
{
    IScenario _scenario;
	void Start ()
    {
        GameObject inst = GameObject.Find("SceneManager");
        ISceneManager man = inst.GetComponent<ISceneManager>();
        _scenario = man.GetScenario();
	}

    float t = 2f;

    void Update ()
    {
        t -= Time.deltaTime;
        if (t<=0)
        {
            ICommand cmd = new CommandChangeScene(HelperSceneID.Menu);
            _scenario.SetCommand(cmd);

        }
	}

   
}
