﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void changeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }

}