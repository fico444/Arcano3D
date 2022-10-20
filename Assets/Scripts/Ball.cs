using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rBody;
    public float initialSpeed = 900;
    bool play;
    Vector3 initialPos;
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    public void Reset()
    {
        SpeedZero();
        transform.position = initialPos;
        transform.SetParent(parent);
        play = false;        
    }

    public void SpeedZero()
    {
        rBody.isKinematic = true;
        rBody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if(!play && Input.GetButtonDown("Jump"))
        {
            play = true;
            transform.SetParent(null);
            rBody.isKinematic = false;
            rBody.AddForce(new Vector3(0,initialSpeed,0));
        }

    }
}
