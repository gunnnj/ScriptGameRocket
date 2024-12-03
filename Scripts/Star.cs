using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour
{
    private const string ScoreKey = "PlayerScore";
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        int score = PlayerPrefs.GetInt(ScoreKey, 0);
        if(score==0){
            star1.SetActive(true);
        }
        else if(score==1){
            star2.SetActive(true);
            star1.SetActive(true);
        }
        else{
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }
    }
    
}
