using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    GameObject bulletObject;
    public GameObject bulletAttackPrefab;
    public GameObject bulletChargeAttackPrefab;
    float attackPressure;
    float maxAttackPressure;
    Rigidbody2D bulletChargeAttackRigidbody;

    void Start()
    {
        attackPressure = 0f;
        maxAttackPressure = 1000f;
        bulletChargeAttackRigidbody = bulletChargeAttackPrefab.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Attack();
        ChargeAttack();
    }

    public void Attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(bulletAttackPrefab, transform.position, Quaternion.identity);
        }
    }

    public void ChargeAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attackPressure = 0f;
            bulletChargeAttackRigidbody.gravityScale = 0f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (attackPressure < maxAttackPressure) {
                attackPressure += Time.deltaTime * 5f;
            } else {
                attackPressure = maxAttackPressure;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (attackPressure > 5f)
            {
                Debug.Log(attackPressure);
                bulletChargeAttackRigidbody.gravityScale = -1f * attackPressure;
                Instantiate(bulletChargeAttackPrefab, transform.position, Quaternion.identity);
            }
        }
    }

}
