using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class option : MonoBehaviour
{
    public GameObject pause;
    public GameObject Option;

    private void Start()
    {
        pause.SetActive(false);
        Option.SetActive(false);
    }

    private void Update()
    {
           Pause();
    }

    public void Pause()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
}
