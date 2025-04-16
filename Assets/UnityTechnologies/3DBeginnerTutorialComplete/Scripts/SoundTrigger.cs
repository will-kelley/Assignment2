using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            source.PlayOneShot(clip);
        }
    }
}
