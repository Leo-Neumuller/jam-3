using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallAndDestroy : MonoBehaviour
{
    public float destroyY = -10.0f;

    private void Update()
    {
        if (transform.position.y <= destroyY)
        {
            Destroy(gameObject);
            Spawner.numItems--; // diminuer le nombre d'objets
        }
    }
}
