using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class FallAndDestroy : MonoBehaviour
{
    public float destroyY = -10.0f;
    public string varProjName;

    private void Update()
    {
        if (transform.position.y <= destroyY)
        {
            Destroy(gameObject);
            int projNumbers = Variables.ActiveScene.Get<int>(varProjName);
            Variables.ActiveScene.Set(varProjName, projNumbers - 1);
        }
    }
}
