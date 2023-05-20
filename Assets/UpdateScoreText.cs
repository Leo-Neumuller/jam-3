using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;

public class UpdateScoreText : MonoBehaviour
{
    public TextMeshProUGUI txt;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = Variables.ActiveScene.Get<int>("Score").ToString();
    }
}
