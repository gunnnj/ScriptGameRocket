using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Read : MonoBehaviour
{
    [SerializeField] AudioSource sound;
    [SerializeField] TextMeshProUGUI Text;
    [SerializeField] string name;

    public void OnClick(){
        Text.text = name;
        sound.Play();
    }
}
