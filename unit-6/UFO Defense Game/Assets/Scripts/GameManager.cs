using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public AudioSource endSound;
    private GameObject gameOverText;
    private bool hasPlayedEndSound = false; // New boolean variable to check if end sound has played

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0 && !hasPlayedEndSound) // Check if time is frozen and sound has not played
        {
            endSound.Play();
            hasPlayedEndSound = true; // Update the boolean variable
            isGameOver = true;
        }
        if (isGameOver)
        {
            EndGame(); // Start EndGame method
        }
        else
            gameOverText.gameObject.SetActive(false); // Keep UI Text Game Over hidden
    }
    public void EndGame()
    {
        Debug.Log("The world ends.");
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; // Freeze Time
    }
}
