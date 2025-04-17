using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = MoveAction.ReadValue<Vector2>();
        Debug.Log(moveInput);
        Vector2 newPosition = rb.position + moveInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);
        animator.SetFloat("Speed", moveInput.magnitude);

        // Handle rotation only when moving
        if (moveInput != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveInput.y, moveInput.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}