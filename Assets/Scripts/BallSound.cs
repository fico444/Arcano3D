using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{

    public AudioSource bounce;
    public AudioSource block;

   void OnCollisionEnter(Collision other)
    {
       if(other.gameObject.CompareTag("BlockTag"))
        {
            block.Play();
        }
        else
        {
            bounce.Play();
        }
    }

}
