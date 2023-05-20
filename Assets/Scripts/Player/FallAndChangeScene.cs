using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallAndChangeScene : MonoBehaviour
{
    public float fallLimit = -10.0f; // la hauteur à laquelle le changement de scène sera déclenché
    public string nextScene = "Assets/Scenes/GameOver.unity"; // le nom de la scène à laquelle passer

    private void Update()
    {
        if (transform.position.y <= fallLimit)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
