using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sartscene : MonoBehaviour
{
    public void Transition()
    {
        SceneManager.LoadScene("Dungeon");
    }
}
