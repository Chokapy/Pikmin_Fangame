using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        // Get input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Set velocity
        Vector2 movement = new Vector2(horizontal, vertical) * speed;
        rb.linearVelocity = movement;

        float movementSpeed = movement.magnitude;
        animator.SetFloat("speed", movementSpeed);

        // Rotate to movement direction if moving
        if (movement != Vector2.zero)
        {
            float angle = Mathf.Atan2(movement.y, movement.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}

