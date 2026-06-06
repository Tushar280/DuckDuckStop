using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed = 5.0f;

    [Header("Input")]
    [SerializeField] private InputActionReference moveActionReference;

    private void Start()
    {
        if (moveActionReference != null)
        {
            moveActionReference.action.Enable();
        }
    }

    private void Update()
    {
        if (moveActionReference == null) return;

        // Read the 2D input vector
        Vector2 moveInput = moveActionReference.action.ReadValue<Vector2>();

        // Calculate translation vector (x, y, 0) scaled by speed and deltaTime
        Vector3 movement = new Vector3(moveInput.x, moveInput.y, 0f) * speed * Time.deltaTime;

        // Move the player (retains existing Z position)
        transform.position += movement;
    }
}
