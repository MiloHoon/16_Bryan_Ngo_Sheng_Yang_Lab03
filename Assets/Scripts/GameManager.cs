using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int currentScore;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        // Get The Variable From PlayerPref To Display On ScoreText
        currentScore = PlayerPrefs.GetInt("PlayerCurrentNails");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        currentScore += 10;
        PlayerPrefs.SetInt("PlayerCurrentLives", currentScore);
        
        // Display Updated Score 
        scoreText.text = "Score: " + currentScore;
    }

    public void MinusScore()
    {
        SceneManager.LoadScene("GameLoseScene");
    }
}
