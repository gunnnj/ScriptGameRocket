using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickLevel : MonoBehaviour
{
    [SerializeField]
    private int level=0;
     public void LoadLevel(){
        SceneManager.LoadScene(level);
    }
}
