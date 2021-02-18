using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private AudioClip metalWalkClip;
    [SerializeField] private AudioClip carpetWalkClip;
    [SerializeField] private AudioSource footstepsSource;
    private string floorType;
    List <GameObject> currentCollisions = new List <GameObject> ();
    public bool switchedOn;
    
    private void Update()
    {
        if (!agent.isStopped)
        {
            if (floorType == "Metal")
            {
                PlayAudio(metalWalkClip);
            }
            else
            {
                Debug.Log("DU");
                PlayAudio(carpetWalkClip);
            }    
        }
        else StopAudio();
    }
    
    private void PlayAudio(AudioClip clipToPlay)
    {
        if (!footstepsSource.isPlaying)
        {
            footstepsSource.clip = clipToPlay;
            footstepsSource.Play(); 
        }

    }

    private void StopAudio()
    {
        if (footstepsSource.isPlaying)
        {
            footstepsSource.Stop();
        } 

    }

    private void SetFloorType(string typeOfFloor)
    {
        floorType = typeOfFloor;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        currentCollisions.Add (other.gameObject);

        foreach (GameObject gObject in currentCollisions)
        {
            if (gObject.CompareTag("Carpet")) SetFloorType("Carpet");
            else SetFloorType("Metal");
        }
    }
}
