using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GotoMenu: MonoBehaviour
{    

    public void Onclicked(){
        SceneManager.LoadScene("Main Scene");
    }
}
