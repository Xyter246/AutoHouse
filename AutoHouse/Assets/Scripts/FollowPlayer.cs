using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    // Set camera position to the player
    void Update()
    {
        transform.position = player.transform.position;
    }
}
