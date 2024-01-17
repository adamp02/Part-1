using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float force = 5f;

    Vector2 direction;

    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {

        rigidbody.AddForce(direction * force * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("The player hit something!");
    }

}
