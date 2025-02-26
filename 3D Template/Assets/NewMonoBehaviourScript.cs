using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float movementSpeed = 5;
    private Rigidbody rb;
    private Vector2 _moveAmount;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.linearVelocity = new Vector3(_moveAmount.x, rb.linearVelocity.y, _moveAmount.y) * movementSpeed;
    }

    public void HandleMovement(InputAction.CallbackContext ctx)
    {
        _moveAmount = ctx.ReadValue<Vector2>();
    }
}
