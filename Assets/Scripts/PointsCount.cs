using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCount : MonoBehaviour
{
    public static int points = 0;
    public Text pointText;
    public GameObject lvlDone;
    public GameObject gameDone;
    public WaitTime waitTimeScript;
    public Ball ballScript;
    public Transform Blocks;
    public Bar barScript;
    public LvlSound lvlSoundScript;


    // Start is called before the first frame update
    void Start()
    {
        RefreshPointText();
    }
    public void RefreshPointText()
    {
        pointText.text = "PUNTOS   " + PointsCount.points;
    }

    public void AddPoints()
    {
        PointsCount.points++;
        RefreshPointText();

        if (Blocks.childCount == 1)
        {
            Debug.Log(Blocks.childCount);
            lvlDone.SetActive(true);
            ballScript.SpeedZero();
            barScript.enabled = false;
            ballScript.enabled = false;
           // waitTimeScript.sceneToLoad = "Menu";
            waitTimeScript.DeelayLoad();
            barScript.Reset();
            ballScript.Reset();
            lvlSoundScript.LvlCompletePlay();
        }


    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
