using UnityEngine;

public class UIButtonSound : MonoBehaviour
{
    public AudioSource clickAudioSource;

    public void PlayClick()
    {
        clickAudioSource.Play();
    }
}