using UnityEngine;

public class DotProductTrigger : MonoBehaviour
{
    public Transform player;
    public GameObject ghost;
    public float threshold = 0.5f;

    void Update()
    {
        Vector3 toGhost = (ghost.transform.position - player.position).normalized;
        float dot = Vector3.Dot(player.forward, toGhost);

        ghost.SetActive(dot > threshold);
    }
}
