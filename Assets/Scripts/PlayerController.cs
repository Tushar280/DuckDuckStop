using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
        float moveHorizontal = 0f;
        float moveVertical = 0f;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
            {
                moveVertical += 1f;
            }
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
            {
                moveVertical -= 1f;
            }
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            {
                moveHorizontal += 1f;
            }
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            {
                moveHorizontal -= 1f;
            }
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        rb2d.linearVelocity = movement * speed;

        
    }
    void FixedUpdate()
    {
    }
}