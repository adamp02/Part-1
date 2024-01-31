using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMove : MonoBehaviour
{

    // Essentially a combination of the 'Tank' in-class demo and the 'Car' demo
    // to create a truck that can move left and right (and tilt from side-to-side).

    Rigidbody2D truckRB;
    public float speed = 3f;
    float steering;
    public float steeringSpeed = 99f;


    // Start is called before the first frame update
    void Start()
    {
        truckRB = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

       steering = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        truckRB.AddTorque(steering * -steeringSpeed * Time.deltaTime);

        float direction = Input.GetAxis("Horizontal");

        transform.Translate(speed * direction * Time.deltaTime, 0, 0);

    }




}
