using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public float speed = 30f;
    Vector3 initialPos;

    // Start is called before the first frame update
    void Start()
    {
         initialPos= transform.position;
    }

     public void Reset()
        {
            transform.position = initialPos;
        }
        
    // Update is called once per frame
    void Update()
    {
      
        float horizontalKey = Input.GetAxisRaw("Horizontal");
        float xPos = transform.position.x + (horizontalKey * speed * Time.deltaTime);

        transform.position = new Vector3(Mathf.Clamp(xPos, -26, +26), transform.position.y, transform.position.z);

        
    }
}