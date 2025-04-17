using UnityEngine;

public class CursorControler : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; // Optional: Lock Z position if in 2D
        transform.position = mousePosition;
    }
}
