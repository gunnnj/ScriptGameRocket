using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnClick : MonoBehaviour
{
    public AudioClip fruits;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = fruits;
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        Debug.Log("Đã nhấn vào đối tượng!");
        audioSource.Play();
    }
}
