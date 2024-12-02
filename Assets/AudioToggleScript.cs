using UnityEngine;

public class AudioToggleScript : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    public void ToggleAudio()
    {
        if (audioSource.isPlaying)
        {
            // Stop the audio if it's currently playing
            audioSource.Stop();
        }
        else
        {
            // Play the audio if it's not currently playing
            audioSource.Play();
        }
    }
}
