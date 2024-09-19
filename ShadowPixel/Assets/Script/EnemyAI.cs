using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    
    private NavMeshAgent _navMeshAgent;
    
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(FollowPlayerRoutine());
        }
    }
    
    IEnumerator FollowPlayerRoutine()
    {
        while (true)
        {
            _navMeshAgent.SetDestination(player.transform.position);
            yield return new WaitForEndOfFrame();
        }
    }

    // private void Update()
    // {
    //     Chasting();
    // }
    // private void Chasting()
    // {
    //     { 
    //         _navMeshAgent.SetDestination(player.transform.position);
    //     }
    // }

    // private void OnTriggerEnter(Collider collision)
    // {
    //     if (collision.gameObject.CompareTag("Player"))
    //     {
    //         StartCoroutine(FollowPlayerRoutine());
    //     }
    // }
    
   
}
