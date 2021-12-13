using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI timer;

    public float LimitTime;

    private void Awake()
    {
       timer = GetComponent<TextMeshProUGUI>();
       LimitTime = 500;
    }

    // Update is called once per frame
    void Update()
    {
        //제한시간
        LimitTime -= Time.deltaTime;
        timer.text = "Limit Time : " + Mathf.Round(LimitTime);
    }
}

