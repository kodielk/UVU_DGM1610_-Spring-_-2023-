using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public int sceneToLoad; 
    
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
        Debug.Log("New scene loaded.");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
