
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource; 
    public AudioClip background;//background audio

    private void Start()
    {
        audioSource.clip = background;
        audioSource.Play();//toggle music when the game starts
    }

    public void ToggleMusic()
    {
        audioSource.mute = !audioSource.mute;
    }
    public void AudioVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
