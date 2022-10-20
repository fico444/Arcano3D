using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public PointsCount PointsCountScript;
    //public Material material1;
   // public Material material2;
   // public Material material3;
    public GameObject particlesFx;
    public int type;

    void OnCollisionEnter()
    {
        if(type > 1)
        {
            type--;
        }
        else
        {
            Instantiate(particlesFx, transform.position, Quaternion.identity);
            PointsCountScript.AddPoints();
            Destroy(gameObject);
            transform.SetParent(null);
        }
        
    }

}
