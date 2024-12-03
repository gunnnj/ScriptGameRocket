using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float timeDelay = 1f;
    [SerializeField] AudioClip crash;
    [SerializeField] AudioClip success;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] ParticleSystem successParticles;
    [SerializeField] PlayerBasket playerBasket;
    private const string ScoreKey = "PlayerScore";
    private const string IndexScene = "IndexScece";
    AudioSource audioSource;
    bool isTransitioning = false;
    bool collisionDisabled = false;
    
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    void Update() {
        RespondToDebugKeys();
    }
    void RespondToDebugKeys() {
        if(Input.GetKeyDown(KeyCode.L)) {
            LoadNextLevel();
        }else if(Input.GetKeyDown(KeyCode.C)) {
            Debug.Log("Disabled");
            collisionDisabled = !collisionDisabled;
        }
    }
    void OnCollisionEnter(Collision other) {
        if(isTransitioning || collisionDisabled) {return;}
        //if(!isTransitioning || !collisionDisabled) {
            switch(other.gameObject.tag) {
                case "Friendly" : 
                    Debug.Log("This thing is friendly");
                    break;
                case "Finish" : 
                    Debug.Log("You finished");
                    StartSuccessSequence();
                    break;
                case "Fuel" : 
                    Debug.Log("You picked up fuel");
                    break;
                default :
                    StartSmashSequence();
                    break;
            }
        //}
    }
    void StartSuccessSequence() {
        isTransitioning = true;
        audioSource.Stop();
        successParticles.Play();
        audioSource.PlayOneShot(success);
        GetComponent<Movement>().enabled = false;
        Invoke("LoadNextLevel", timeDelay);
    }
    void StartSmashSequence() {
        isTransitioning = true;
        audioSource.Stop();
        crashParticles.Play();
        audioSource.PlayOneShot(crash);
        GetComponent<Movement>().enabled = false;
        Invoke("ReloadLevel", timeDelay);
    }
    void ReloadLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    void LoadNextLevel() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex==8){
            SceneManager.LoadSceneAsync(9);
        }
        PlayerPrefs.SetInt(ScoreKey, playerBasket.score);
        PlayerPrefs.SetInt(IndexScene, currentSceneIndex);
        Debug.Log(currentSceneIndex);
        PlayerPrefs.Save();
        SceneManager.LoadSceneAsync("Pass");
    }
}
