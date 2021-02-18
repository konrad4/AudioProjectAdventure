using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAudio : MonoBehaviour
{
    [SerializeField] private AudioClip[] metalWalkClips;
    [SerializeField] private AudioClip[] sandWalkClips;
    [SerializeField] private AudioSource footstepsSource;
    [SerializeField] private GameObject secondHandGameObject;
    [SerializeField] private GameObject playerGameObject;
    private Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    private void Update()
    {
        if ((secondHandGameObject.transform.position - playerGameObject.gameObject.transform.position).sqrMagnitude < 50f)
        {
            Debug.Log("jest");
        }
        else
        {
            Debug.Log("nie ma");
        }
    }

    private void PlayRandomSound(AudioClip[] clips)
    {
        var soundIndex = UnityEngine.Random.Range(0, clips.Length);
        footstepsSource.PlayOneShot(clips[soundIndex]);
    }

    private void Step()
    {
        if (scene.name == "SecurityRoom")
        {
            PlayRandomSound(metalWalkClips);
        }
        else
        {
            PlayRandomSound(sandWalkClips);
        }
    }
}
