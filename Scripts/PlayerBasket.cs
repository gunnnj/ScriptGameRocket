using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBasket : MonoBehaviour
{
    [SerializeField] public int score;
    
    void Start()
    {
        score = 0;
    }
    
}
