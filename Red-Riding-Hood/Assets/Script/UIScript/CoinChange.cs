using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CoinChange : MonoBehaviour
{
    // Start is called before the first frame update
    public Text myText;
    void Start()
    {
        myText = GameObject.Find("coinText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // myText.text = String.Format("{0}",Player.flower);
    }
}

