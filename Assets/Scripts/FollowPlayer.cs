using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }

}
