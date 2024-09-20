using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemywatchside : MonoBehaviour
{
    public GameObject Player;
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;
    
    void Start()
    {
        left.SetActive(false);
        right.SetActive(false);
        up.SetActive(false);
        down.SetActive(true);
        Enemyside();
    }

  
    void Update()
    {
        
    }
    
    public void Enemyside()
    {
        if (Player.transform.position.x > transform.position.x)
        {
            left.SetActive(false);
            right.SetActive(true);
            up.SetActive(false);
            down.SetActive(false);
        }

        if (Player.transform.position.x < transform.position.x)
        {
            left.SetActive(true);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(false);
        }

        if (Player.transform.position.y > transform.position.y)
        {
            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(true);
            down.SetActive(false);
        } 
        
        if (Player.transform.position.y < transform.position.y)
        {
            left.SetActive(false);
            right.SetActive(false);
            up.SetActive(false);
            down.SetActive(true);
        }
    }
}
