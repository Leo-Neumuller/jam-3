using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public float throwForce = 500;  // Modify this value as per your needs
    public Vector2 direction = new Vector2(1, 1);  // Modify this value as per your needs

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Throw();
    }

    void Throw()
    {
        // Normalize the direction vector so that it has a magnitude of 1
        // This ensures that the throwForce you set is the actual force applied to the object
        direction = direction.normalized;

        // Apply the force to the Rigidbody2D
        rb.AddForce(direction * throwForce);
    }
}
