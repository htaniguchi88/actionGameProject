using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    void Start() {
        Vector3 tmp = GameObject.Find("Player").transform.position;
        transform.position = new Vector3(tmp.x, -3, tmp.z);
    }

    void Update()
    {
        float pressure = 4.2f;
        transform.Translate(0, 0.18f * pressure, 0);
    }
}
