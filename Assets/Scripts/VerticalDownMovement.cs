using UnityEngine;

public class VerticalDownMovement : MonoBehaviour
{
    void Start()
    {
        Vector3 tmp = GameObject.Find("Player").transform.position;
    }

    void Update()
    {
        transform.Translate(0, -0.01f, 0);
    }
}
