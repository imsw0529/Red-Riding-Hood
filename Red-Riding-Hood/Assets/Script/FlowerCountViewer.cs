using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlowerCountViewer : MonoBehaviour
{
   [SerializeField]
   private StageController stageController;
   private TextMeshProUGUI textFlowerCount;

   private void Awake(){
       textFlowerCount = GetComponent<TextMeshProUGUI>();
   }

   private void Update(){
       textFlowerCount.text = "Flower : "+stageController.CurrentFlowerCount+"/"+stageController.MaxFlowerCount;
   }
}
