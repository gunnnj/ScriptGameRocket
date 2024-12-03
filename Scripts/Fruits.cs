using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Fruits : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    [SerializeField] PlayerBasket playerBasket;

    [SerializeField] TextMeshProUGUI Text;
    [SerializeField] string name;
    
    void Start()
    {
        Text.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            sound.Play();
            playerBasket.score++;
            Destroy(gameObject);
            StartCoroutine(Display());
        }
    }
    
    IEnumerator Display(){
        Text.text = name;
        Text.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        Text.gameObject.SetActive(false);
    }
}
