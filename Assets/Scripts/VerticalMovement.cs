using UnityEngine;

public class VerticalMovement : MonoBehaviour
{

    void Start() {
        Vector3 tmp = GameObject.Find("Player").transform.position;
        transform.position = new Vector3(tmp.x, -3, tmp.z);
    }

    void Update()
    {
        transform.Translate(0, 0.18f, 0);
    }
}
