using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetScoreGameOver : MonoBehaviour
{
    
    private TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Score: " + PlayerPrefs.GetInt("Score").ToString();
    }
}
