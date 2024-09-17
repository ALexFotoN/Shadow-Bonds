using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class option : MonoBehaviour
{
    private bool PauseGame;
    public GameObject PauseMenu;

    public void Resume()
    {
        PauseMenu.SetActive(false);
        PauseGame = false;
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
}
