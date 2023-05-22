using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class IncreaseDifficulty : MonoBehaviour
{
    public float interval = 2f; // execution interval

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteEveryInterval());
    }

    IEnumerator ExecuteEveryInterval()
    {
        while (true) // endless loop
        {
            yield return new WaitForSeconds(interval); // wait for the interval
            IncreaseMaxObjects(); // method you want to execute
        }
    }

    void IncreaseMaxObjects()
    {
        int nbRocks = Variables.ActiveScene.Get<int>("MaxRock");
        int nbProj = Variables.ActiveScene.Get<int>("MaxProj");
        
        Variables.ActiveScene.Set("MaxRock", nbRocks + 1);
        Variables.ActiveScene.Set("MaxProj", nbProj + 1);
    }
}
