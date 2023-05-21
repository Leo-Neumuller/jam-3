using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;


public class Grass : MonoBehaviour
{
    public ParticleSystem leafParticle;

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (transform.position.x - col.transform.position.x > 0) 
        {
            GetComponent<Animator>().Play("MovingGrassL");
        }
        else 
        {
            GetComponent<Animator>().Play("MovingGrassR");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            UpdateScore();
        }
    }
    
    private void UpdateScore()
    {
        int score = Variables.ActiveScene.Get<int>("Score");

        score += 10;

        Variables.ActiveScene.Set("Score", score);
    }
    public void ApplyDamage(float damage)
    {
        Instantiate(leafParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}