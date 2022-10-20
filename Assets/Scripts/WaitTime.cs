using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitTime : MonoBehaviour
{

    public string sceneToLoad;
    public float waitTime;

    public void DeelayLoad()
    {
        Invoke("LoadLvl", waitTime);
    }

    public void LoadLvl()
    {
      SceneManager.LoadScene(sceneToLoad);
    }
}
