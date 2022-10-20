using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveCount : MonoBehaviour
{

    public static int lives = 3;
    public Text liveText;
    public Ball BallScript;
    public Bar BarScript;
    public GameObject gameOverText;
    public WaitTime waitTimeScript;
    public LvlSound lvlSoundScript;


    // Start is called before the first frame update
    void Start()
    {
        RefreshLiveText();
    }

    public void LostLive()
    {
        if (LiveCount.lives <= 0)
        {
            return;
        }  

            LiveCount.lives--;
            RefreshLiveText();

        if (LiveCount.lives == 0)
        {
            gameOverText.SetActive(true);
            BallScript.SpeedZero();
            BarScript.enabled = false;
            BallScript.enabled = false;
            waitTimeScript.sceneToLoad = "Menu";
            waitTimeScript.DeelayLoad();
            lvlSoundScript.GameOverPlay();
        }
                
            BarScript.Reset();
            BallScript.Reset();
       

    }

    public void RefreshLiveText()
    {
        liveText.text = "VIDAS   " + LiveCount.lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
