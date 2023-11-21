using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button start;
    public Button Exit;
    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(StartGame);
        Exit.onClick.AddListener(ExitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
    void ExitGame()
    {
        Application.Quit();
    }
}
