using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string newGameScene;
    public string optionsScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void OpenOptions() {
        SceneManager.LoadScene(optionsScene);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
