using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    public Collider2D Collider;
    
    private NavMeshAgent _navMeshAgent;
    
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.updateRotation = false;
        _navMeshAgent.updateUpAxis = false;
    }
    
    private void Update()
    {
        Chasting();
    }
    private void Chasting()
    {
        { 
            _navMeshAgent.SetDestination(player.transform.position);
        }
    }

   
}
