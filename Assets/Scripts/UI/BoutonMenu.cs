using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoutonMenu : MonoBehaviour
{
    public string scenepath = "Assets/Scenes/Game.unity";

    public void ChangeScene()
    {
        SceneManager.LoadScene(scenepath);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
