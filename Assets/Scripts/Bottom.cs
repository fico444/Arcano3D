using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom : MonoBehaviour
{
    public LiveCount LiveCountScript;
    void OnCollisionEnter()
    {
        LiveCountScript.LostLive(); 

    }

}