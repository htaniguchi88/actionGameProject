using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    GameObject bulletObject;
    public GameObject bulletAttackPrefab;
    public GameObject bulletChargeAttackPrefab;
    float attackPressure;
    float maxAttackPressure;
    Rigidbody2D bulletRigidbody;
    Rigidbody2D bulletChargeAttackRigidbody;

    void Start()
    {
        attackPressure = 0f;
        maxAttackPressure = 1000;
        bulletRigidbody = bulletAttackPrefab.GetComponent<Rigidbody2D>();
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
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("hoge");
            bulletChargeAttackRigidbody.gravityScale = 0f;
            attackPressure = 0f;
            Instantiate(bulletChargeAttackPrefab, transform.position, Quaternion.identity);
            if (attackPressure < maxAttackPressure) {
                attackPressure += Time.deltaTime * 100f;
            } else {
                attackPressure = maxAttackPressure;
            }
        } else {
            if (attackPressure > 0f) {
                //bulletRigidbody.velocity = new Vector3(0f, attackPressure, 0f);
                bulletChargeAttackRigidbody.gravityScale = -attackPressure/2f;
            }
        }
    }

}
