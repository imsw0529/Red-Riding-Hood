using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour
{
    private int maxFlowerCount;
    private int currentFlowerCount;

    public int MaxFlowerCount => maxFlowerCount;
    public int CurrentFlowerCount => currentFlowerCount;
    
    [SerializeField]
    private Player player;

    [SerializeField]
    private string nextSceneName;

    [SerializeField]
    private GameObject panelStageClear;
    private bool getAllFlowers = false;

    [SerializeField]
    private Timer timer;

    private void Awake()
    {
        //시간 속도 1.0
        Time.timeScale = 1.0f;
        //클리어 화면 비활성화
        panelStageClear.SetActive(false);

        maxFlowerCount = player.maxFlower;
        currentFlowerCount = 0;
    }

    private void Update()
    {
        currentFlowerCount = player.flower;

        //모든 꽃 획득시
        if (currentFlowerCount == 5)
        {
            getAllFlowers = true;
            
            //일시정지
            Time.timeScale = 0.0f;

            //클리어화면 활성화
            panelStageClear.SetActive(true);
        }

        if (getAllFlowers == true)
        {
            //Enter 입력
            if(Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
