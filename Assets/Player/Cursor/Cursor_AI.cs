using UnityEngine;

public class Cursor_AI : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = false;
    }

    // FixedUpdate is called 50 times per second
    void FixedUpdate()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Optional: Lock Z position if in 2D
        transform.position = mousePosition;
    }
}