﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WInScene : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ToMainMenu);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
