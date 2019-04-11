using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    GameObject bulletObject;
    public GameObject bulletAttackPrefab;
    float attackPressure;
    float maxAttackPressure;

    void Start()
    {
        attackPressure = 0f;
        maxAttackPressure = 10f;
    }

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

    public void ChargeAttack()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (attackPressure < maxAttackPressure) {
                attackPressure += Time.deltaTime * 10f;
            } else {
                attackPressure = maxAttackPressure;
            }
        } else {
            if (attackPressure > 0f) {
                
            }
        }
    }

}
