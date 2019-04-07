using UnityEngine;

public class OnCollisionDestroyer : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(gameObject);
        if (coll.gameObject.tag != "Border") Destroy(coll.gameObject);
    }
}
