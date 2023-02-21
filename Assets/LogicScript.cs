//This script is to keep track of player's score and restart the game.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText; //Update the UI.
    public GameObject gameOverScreen;
    public AudioSource scoreSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreSFX.Play();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void returnToMenu()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
