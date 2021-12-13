using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class TimeChange : MonoBehaviour
{
    // Start is called before the first frame update
    public Text myText;
    public int maxTime = 100;
    double nowTime; 
    int finalTime;

    void Start()
    {
        myText = GameObject.Find("timeText").GetComponent<Text>();
        TimeSpan time = DateTime.Now.TimeOfDay;
        nowTime = time.TotalSeconds;
        finalTime = maxTime;
    }
 
    // Update is called once per frame
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        double timeDif = time.TotalSeconds-nowTime;
        finalTime = maxTime-(int)timeDif;
        myText.text = String.Format("{0}",finalTime);
       
    }

}
