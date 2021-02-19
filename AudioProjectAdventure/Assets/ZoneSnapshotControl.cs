using UnityEngine;
using UnityEngine.Audio;

public class ZoneSnapshotControl : MonoBehaviour
{
    [SerializeField] private GameObject zoneBorderGameObject;
    [SerializeField] private GameObject playerGameObject;
    [SerializeField] private AudioMixerSnapshot zone1Snapshot;
    [SerializeField] private AudioMixerSnapshot zone2Snapshot;

    private const float transitionDuration = 2f;
    
    private void Update()
    {
        if ((zoneBorderGameObject.transform.position - playerGameObject.gameObject.transform.position).sqrMagnitude < 50f)
        {
            zone2Snapshot.TransitionTo(transitionDuration);
        }
        else
        {
            zone1Snapshot.TransitionTo(transitionDuration);
        }
    }
}
