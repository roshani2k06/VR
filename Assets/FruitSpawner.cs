using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits;
    public Transform spawnArea;

    public float spawnTime = 2f;
    public int maxFruits = 10;

    int currentFruits = 0;

    void Start()
    {
        InvokeRepeating("SpawnFruit", 1f, spawnTime);
    }

    void SpawnFruit()
    {
        if (currentFruits >= maxFruits)
            return;

        int randomFruit = Random.Range(0, fruits.Length);

        Vector3 randomPos = spawnArea.position +
            new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2));

        Instantiate(fruits[randomFruit], randomPos, Quaternion.identity);

        currentFruits++;
    }
}