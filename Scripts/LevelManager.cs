using Assets.Scripts.Static;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    private int indexScrene;
    [SerializeField] TextMeshProUGUI complete;
    private const string IndexScene = "IndexScece";

    void Start()
    {
        indexScrene = PlayerPrefs.GetInt(IndexScene, 0);
        if(complete!=null){
            complete.text = $"Level {indexScrene} complete!";
        }    
        Debug.Log(indexScrene);
    }
    public void LoadMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    public void LoadGame() {
        SceneManager.LoadScene("Fly Over");
    }
    public void LoadScene(){
        if(indexScrene>=5){
            SceneManager.LoadScene("Main Menu");
        }else{
            SceneManager.LoadScene(indexScrene+1);
        }
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
   
    public void LoadMenuLV()
    {
        SceneManager.LoadScene("Level");
    }
    public void LoadReview()
    {
        SceneManager.LoadScene("Gallery");
    }
    public void Again()
    {
        SceneManager.LoadScene(indexScrene);
    }

    public void QuitGame() {
        Debug.Log("Quitting Game....");
        Application.Quit();
    }
}
