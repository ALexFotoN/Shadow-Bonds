using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class option : MonoBehaviour
{
    public GameObject pause;
    public GameObject Option;

    private bool ispause;

    private void Start()
    {
        pause.SetActive(false);
        Option.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
       
    }
    
    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f; 
        ispause = true;
    }

    public void Resume()
    {
        pause.SetActive(false);
        Option.SetActive(false);
        Time.timeScale = 1f;
        ispause = false;
    }
    
}
