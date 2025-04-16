using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    public ParticleSystem particles;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            particles.Play();
        }
    }
}
