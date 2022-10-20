using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
   
    // Update is called once per frame
    
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Sale del juego");
            Application.Quit();
        }
      
        if ( Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space))
        {
            LiveCount.lives = 3;
            PointsCount.points = 0;
            Debug.Log("Enter");
            SceneManager.LoadScene("Lvl1");
        }

       
    }
}
