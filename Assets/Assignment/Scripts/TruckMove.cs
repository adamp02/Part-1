using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMove : MonoBehaviour
{

    Rigidbody2D rigidbody;
    public float speed = 3f;
    float steering;
    public float steeringSpeed = 30;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float direction = Input.GetAxis("Horizontal");

        transform.Translate(speed * direction * Time.deltaTime, 0, 0);

       // steering = Input.GetAxis("Horizontal");



    }

    private void FixedUpdate()
    {
        //rigidbody.AddTorque(steering * -steeringSpeed * Time.deltaTime);

    }


}
