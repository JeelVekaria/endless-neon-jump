using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMessages : MonoBehaviour
{
    // Start is called before the first frame update
    private int randomMssgIndex =0;
    private int highScore;
    private int currentScore =0;

    
    void Start()
    {
        randomMssgIndex = Random.Range(1,2);
        if(PlayerPrefs.GetInt("highscoreValue")==0){
            highScore = 0;
        }
        else{
            highScore = PlayerPrefs.GetInt("highscoreValue");
        }
    }

    void Update(){

        // highScore = GameManager.highScore;
        currentScore = Score.score;
        highScore = PlayerPrefs.GetInt("highscoreValue");

        if (currentScore>highScore){
            highScore = currentScore;
            PlayerPrefs.SetInt("highscoreValue",highScore);
            highScore = PlayerPrefs.GetInt("highscoreValue");
        }

        string scoreDisplay = $"\nCurrent Score: {currentScore}\n High Score: {highScore}";

        switch(randomMssgIndex){
            case 1:
                // GetComponent<TMPro.TextMeshProUGUI>().text = $"Better Luck Next Time! {scoreDisplay}";
                GetComponent<UnityEngine.UI.Text>().text = $"Better Luck Next Time! {scoreDisplay}";
                break;
            case 2:
                // GetComponent<TMPro.TextMeshProUGUI>().text= $"You Did Well!{scoreDisplay}";
                break;
            case 3:
            //    GetComponent<TMPro.TextMeshProUGUI>().text = $"Oh man you got so far!{scoreDisplay}";
                break;
            case 4:
                // GetComponent<TMPro.TextMeshProUGUI>().text = $"Impressive Score!{scoreDisplay}";
                break;
            default:
                // GetComponent<TMPro.TextMeshProUGUI>().text = $"Impressive Score!{scoreDisplay}";
                break;
        }
    }

}
