using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 0.18f, 0);
        if (transform.position.y > 4) Destroy(gameObject);
    }
}
