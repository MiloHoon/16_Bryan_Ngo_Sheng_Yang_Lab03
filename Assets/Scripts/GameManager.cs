using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentScore;
    public float timeLeft = 60.0f;

    public Text scoreText;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Score();
        Timer();
    }

    public void Score()
    {
        // Display Updated Score 
        scoreText.text = "Score: " + currentScore;

        if (currentScore == 100)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void AddScore()
    {
        currentScore += 10;
    }

    public void MinusScore()
    {
        SceneManager.LoadScene("GameLoseScene");
    }

    public void Timer()
    {
        timeLeft -= Time.deltaTime;

        // Display Updated Score 
        timerText.text = "Time: " + (timeLeft).ToString("0");

        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameLoseScene");
        }
    }
}