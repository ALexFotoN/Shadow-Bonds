using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOption : MonoBehaviour
{
    public GameObject Pause;
    public GameObject Option;

    public void buttonOnClik()
    {
        Pause.SetActive(false);
        Option.SetActive(true);
    }
    
}
