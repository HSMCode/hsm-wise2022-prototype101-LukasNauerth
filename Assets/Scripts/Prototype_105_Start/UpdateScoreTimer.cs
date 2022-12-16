using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScoreTimer : MonoBehaviour
{
    private GameObject _gameUI;
    private GameObject _gameOverUI;

    private Text scoreUI;
    public string scoreText = "Punktestand: ";
    private int currentScore = 0;
    public int addScore = 1;
    public int winScore = 5;

      private Text timerUI;
      public string timerText ="Countdown: ";
      public float countRemaining = 10f;
      private bool countingDown=true;

      private Text resultUI;
      public string resultLost = "You lost!";
      public string resultWin = "You won!";

      //variables for game over
      public bool gameOver;
      private bool gameWon;
      private bool gameLost;

    // Start is called before the first frame update
    void Start()
    {
        _gameUI = GameObject.Find("Game");
        _gameOverUI = GameObject.Find("GameOver");

        scoreUI = GameObject.Find("Score").GetComponent<Text>();
        timerUI = GameObject.Find("Timer").GetComponent<Text>();
        resultUI = GameObject.Find("Result").GetComponent<Text>();

        _gameUI.SetActive(true);
        _gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Countdowntimer();
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            currentScore += addScore;
            scoreUI.text = scoreText + currentScore.ToString();
        }
    }

    private void Countdowntimer()
    {
        if(countingDown)
        {
          if(countRemaining>  0)
            {
                countRemaining -= Time.deltaTime;
                timerUI.text= timerText + Mathf.Round(countRemaining).ToString();
            }

            else
            {
                countRemaining = 0;
                timerUI.text = timerText + countRemaining.ToString();
                countingDown = false;

                CheckGameOver();
            }

        }
    }

    private void CheckGameOver(){
        //GameOver WIN
        if(currentScore>= winScore)
        {
            gameWon = true;

        resultUI.text=resultWin;
        resultUI.color = color.green;
            Debug.Log("WIN" + gameWon);
        }

        //GameOver LOST
        else if(currentScore< winScore && !countingDown)
        {
            gameLost=true;

            resultUI.text=resultLost;
            resultUI.color= color.red;
            Debug.Log("LOST " + gameLost);
        }
    }


}
