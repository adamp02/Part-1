using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    Rigidbody2D rigidbody;


    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        // Destroy object if it flies off screen
        if (rigidbody.position.y > 10) {
            Destroy(this.gameObject);
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Flip the gravity to activate the "magnet"
        rigidbody.gravityScale = -1;
    }
}
