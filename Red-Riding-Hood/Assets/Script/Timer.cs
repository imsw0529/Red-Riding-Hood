using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private int maxHunterCount;
    private int currentHunterCount;

    private TextMeshProUGUI timer;

    public float LimitTime;

    [SerializeField]
    private Player player;

    private void Awake()
    {
       timer = GetComponent<TextMeshProUGUI>();
       LimitTime = 300;

       maxHunterCount = player.maxHunter;
       currentHunterCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentHunterCount = player.hunter;

        //제한시간
        LimitTime -= Time.deltaTime;
        timer.text = "Limit Time : " + Mathf.Round(LimitTime);

        if(currentHunterCount == 1)
        {
            LimitTime += 60;
            player.hunter = 0;
            currentHunterCount = 0;
        }
    }
}

