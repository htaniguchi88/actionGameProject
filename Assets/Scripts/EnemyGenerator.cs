using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject RedSquareEnemyPrefab;

    void Start()
    {
        InvokeRepeating("GenerateRedSquare", 1, 1);
    }

    void GenerateRedSquare()
    {
        Instantiate(RedSquareEnemyPrefab, new Vector3(-5 + 10 * Random.value, 6, 0), Quaternion.identity);
    }
}
