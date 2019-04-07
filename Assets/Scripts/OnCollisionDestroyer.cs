using UnityEngine;

public class OnCollisionDestroyer : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
