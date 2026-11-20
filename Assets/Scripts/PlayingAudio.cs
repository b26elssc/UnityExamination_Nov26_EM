using UnityEngine;

public class PlayingAudio : MonoBehaviour
{
    [SerializeField]private AudioSource audioSource;

    public void PlaySound()
    {
        audioSource.Play();
    }
}
