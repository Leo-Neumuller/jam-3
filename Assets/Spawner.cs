using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject itemToSpawn;
    public float spawnInterval = 1.0f;
    public float minX = -10.0f;
    public float maxX = 10.0f;
    public float spawnY = 10.0f;
    public static int numItems = 0; // garder une trace du nombre d'objets
    public int maxItems = 3; // le nombre maximum d'objets qui peuvent être présents en même temps

    private void Start()
    {
        StartCoroutine(SpawnItems());
    }

    private IEnumerator SpawnItems()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            if (numItems < maxItems) // seulement créer un nouvel objet si la limite n'est pas atteinte
            {
                float randomX = Random.Range(minX, maxX);
                GameObject tmp = Instantiate(itemToSpawn, new Vector3(randomX, spawnY, 0), Quaternion.identity);
                numItems++; // augmenter le nombre d'objets
            }
        }
    }
}
