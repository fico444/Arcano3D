using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayExit : MonoBehaviour
{
    
    // Update is called once per frame

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Carga el menu");
            SceneManager.LoadScene("Menu");
        }

      
    }
}