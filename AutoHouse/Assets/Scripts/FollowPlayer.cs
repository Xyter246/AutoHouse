using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;

    // Set camera position to the player
    void Update() {
        Vector3 newPos = new Vector3(player.position.x, player.position.y, -100f);
        transform.position = Vector3.Slerp(transform.position, newPos, 1);
    }
}
