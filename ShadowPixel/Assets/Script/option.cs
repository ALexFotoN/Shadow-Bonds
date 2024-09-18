using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class option : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Option;

    private void Start()
    {
        Pause.SetActive(false);
        Option.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            Pause.SetActive(true);
        }
        
    }

   


    // public bool PauseGame;
    // public GameObject PauseMenu;
    //
    //
    // public void Start()
    // {
    //     PauseMenu.SetActive(false);
    // }
    //
    // public void Resume()
    // {
    //     PauseMenu.SetActive(false);
    //     PauseGame = false;
    // }
    //
    // public void Pause()
    // {
    //     PauseMenu.SetActive(true);
    //     PauseGame = true;
    // }
    //
    // public void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Escape))
    //     {
    //         if (PauseGame)
    //         {
    //             Resume();
    //         }
    //         else
    //         {
    //             Pause();
    //         }
    //     }
    // }


}
