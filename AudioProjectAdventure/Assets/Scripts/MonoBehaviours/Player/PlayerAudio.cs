using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    // Update is called once per frame

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other);
    }
}
