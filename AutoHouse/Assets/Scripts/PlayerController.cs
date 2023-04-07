using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour {

    // Create variables
    [SerializeField] private float _Speed;
    private Vector2 _Movement;
    private Rigidbody2D _Rigidbody;

    // if object gets loaded; get Rigidbody input
    private void Awake() {
        _Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Upon use of WASD get Vector2
    private void OnMovement(InputValue value) {
        _Movement = value.Get<Vector2>();
    }

    // every tick; move player in direction of input with set speed
    private void FixedUpdate() {
        _Rigidbody.velocity = _Movement * _Speed;
    }
}
