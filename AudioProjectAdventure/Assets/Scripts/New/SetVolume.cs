using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SetVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private string exposedFieldName;
    [SerializeField] private bool isGlobal;

    private static string GetSceneName()
    {
        return UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
    }

    private static float GetValue(float passedValue)
    {
        return Mathf.Log10(passedValue) * 20;
    }
    
    public void SetLevel(float sliderValue)
    {
        if (isGlobal) mixer.SetFloat(exposedFieldName, GetValue(sliderValue));
        else mixer.SetFloat(GetSceneName() + exposedFieldName, GetValue(sliderValue));
    }
}
