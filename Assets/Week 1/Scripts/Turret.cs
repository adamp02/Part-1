using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{


    public float rotationSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float direction = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, rotationSpeed * direction * Time.deltaTime);

    }
}
