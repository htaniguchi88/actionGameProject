using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    GameObject bulletObject;
    public GameObject bulletAttackPrefab;

    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletAttackPrefab, transform.position, Quaternion.identity);
        }
    }

}
