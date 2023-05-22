using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class ObjectSpawner : MonoBehaviour
{
    // Variables
    public GameObject objectToSpawn; // assign the prefab in the inspector
    private BoxCollider spawnArea; // BoxCollider representing the spawn area
    public string maxItems;
    private float spawnInterval = 1.0f;
    public string varProjName;

    // Use this for initialization
    void Start()
    {
        spawnArea = GetComponent<BoxCollider>();
        if(spawnArea == null)
        {
            Debug.LogError("No BoxCollider found! Please attach a BoxCollider to define the spawn area.");
            return;
        }

        StartCoroutine(SpawnItems());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnObject()
    {
        Vector3 pos = new Vector3(
            Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
            Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
            Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z)
        );

        Instantiate(objectToSpawn, pos, Quaternion.identity);
    }
    
    private IEnumerator SpawnItems()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            int projNumbers = Variables.ActiveScene.Get<int>(varProjName);
            int max = Variables.ActiveScene.Get<int>(maxItems);
            
            if (projNumbers < max) // seulement créer un nouvel objet si la limite n'est pas atteinte
            {
                float randomX = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
                float randomY = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
                GameObject tmp = Instantiate(objectToSpawn, new Vector3(randomX, randomY, 0), Quaternion.identity);
                tmp.SetActive(true);
                Variables.ActiveScene.Set(varProjName, projNumbers + 1);
            }
        }
    }
    
}
