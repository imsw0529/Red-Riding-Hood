using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{
    private int maxFlowerCount;
    private int currentFlowerCount;

    public int MaxFlowerCount => maxFlowerCount;
    public int CurrentFlowerCount => currentFlowerCount;

    [SerializeField]
    private Player player;
    
    private void Awake()
    {
        maxFlowerCount = player.maxFlower;
        currentFlowerCount = 0;
    }

    private void Update()
    {
        currentFlowerCount = player.flower;
    }

}
