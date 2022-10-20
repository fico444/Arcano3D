using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlSound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip lvlComplete;
    public AudioClip gameOver;

    public void GameOverPlay()
    {
        audioSource.clip = gameOver;
        audioSource.loop = false;
        audioSource.Play();
    }

    public void LvlCompletePlay()
    {
        audioSource.clip = lvlComplete;
        audioSource.loop = false;
        audioSource.Play();
    }

}
