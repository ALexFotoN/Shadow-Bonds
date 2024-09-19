using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class COnflict : MonoBehaviour
{
    public int playerHp;
    public int numofhearts;
    // public int vectornumber;
    public List<Image> hearts = new List<Image>();
    // public Image heartsimage;
    
    
    private Rigidbody2D rb;
    private bool isHitting = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Hearts();
        
        if (isHitting)
        {
            TakeDamage();
        }

        if (playerHp == 0)
        {
            
            SceneManager.LoadScene("End");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(TakeDamage());
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            StopCoroutine(TakeDamage());
            isHitting = false;
        }
    }

    IEnumerator TakeDamage()
    {
        isHitting = true;
        while (isHitting)
        {
            playerHp -= 1;
            yield return new WaitForSeconds(1); 
        }
        isHitting = false;
    }

    public void Hearts()
    {
        for (int i = 9; i >= 0; i--)
        {
            if (playerHp == i)
            {
                Image heart = hearts[i];
                heart.gameObject.SetActive(false);
            }
        }
        
        // for (; vectornumber != 600; vectornumber -= 60)
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         var heart = Instantiate(heartsimage, transform.position + new Vector3(vectornumber, 278, 0), quaternion.identity);
        //         hearts.Add(heart);
        //     }
        // }

        // if (playerHp == 9)
        // {
        //     Image heart9 = hearts[9];
        //     heart9.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 8)
        // {
        //     Image heart8 = hearts[8];
        //     heart8.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 7)
        // {
        //     Image heart7 = hearts[7];
        //     heart7.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 6)
        // {
        //     Image heart6 = hearts[6];
        //     heart6.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 5)
        // {
        //     Image heart5 = hearts[5];
        //     heart5.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 4)
        // {
        //     Image heart4 = hearts[4];
        //     heart4.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 3)
        // {
        //     Image heart3 = hearts[3];
        //     heart3.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 2)
        // {
        //     Image heart2 = hearts[2];
        //     heart2.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 1)
        // {
        //     Image heart1 = hearts[1];
        //     heart1.gameObject.SetActive(false);
        // }
        //
        // if (playerHp == 0)
        // {
        //     Image heart0 = hearts[0];
        //     heart0.gameObject.SetActive(false);
        // }
       
    }
    
    
}
