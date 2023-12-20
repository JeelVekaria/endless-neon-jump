using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreDisplay;
    public GameObject homeScreen;

    
    // public static int highScore=0;
    private bool clicked;

    void Start(){
        Time.timeScale = 0;
        gameOverCanvas.SetActive(false);
        scoreDisplay.SetActive(false);

    }
    void Update(){
        if(Input.GetMouseButtonDown(0) && clicked!=true || Input.GetKeyDown(KeyCode.Space) && clicked!=true){
            Time.timeScale=1;
            clicked=true;
            scoreDisplay.SetActive(true);
            homeScreen.SetActive(false);
        }

    }
    public void GameOver(){
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }

    public void Replay(){
        homeScreen.SetActive(false);

        SceneManager.LoadScene(0);
    }
}
