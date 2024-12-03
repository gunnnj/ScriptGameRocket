using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spell : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Text;
    public AudioSource[] audios;

    public void Spelling(){
        if(Text.text.Equals("APPLE")){
            audios[0].Play();
        }
        else if(Text.text.Equals("BANANA")){
            audios[1].Play();
        }
        else if(Text.text.Equals("WATERMELON")){
            audios[2].Play();
        }
        else if(Text.text.Equals("STRAWBERRY")){
            audios[3].Play();
        }
        else if(Text.text.Equals("ORANGE")){
            audios[4].Play();
        }
        else if(Text.text.Equals("TOMATO")){
            audios[5].Play();
        }
        else if(Text.text.Equals("PEPPER")){
            audios[6].Play();
        }
        else if(Text.text.Equals("CUCUMBER")){
            audios[7].Play();
        }
        else if(Text.text.Equals("CARROT")){
            audios[8].Play();
        }
        else if(Text.text.Equals("CABBAGE")){
            audios[9].Play();
        }
    }
}
