using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using static UnityEngine.GraphicsBuffer;

public class PikminFollow : MonoBehaviour
{
    public Transform player;  // Reference to the player (can be assigned in inspector)
    public float followSpeed = 2f;
    public float followDistance = 2f;  // Minimum distance to the player
    public float stopDistance = 0.5f;  // Stop when within this range

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (player == null)
        {
            GameObject Player = GameObject.Find("Player"); // Find by name
            if (Player != null)
            {
                player = Player.transform;
            }
        }
    }

    void FixedUpdate()
    {
        if (player == null) return;

        // Calculate direction to the player
        Vector2 direction = (player.position - transform.position).normalized;
        float distance = Vector2.Distance(transform.position, player.position);

        // Move if the distance is greater than the stop distance
        if (distance > stopDistance)
        {
            rb.linearVelocity = direction * followSpeed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
        if (direction != Vector2.zero)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle+90);
        }
    }
}
