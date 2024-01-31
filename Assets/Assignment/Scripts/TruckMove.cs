using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMove : MonoBehaviour
{

    Rigidbody2D truckRB;
    public float speed = 3f;
    float steering;
    public float steeringSpeed = 30;


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
