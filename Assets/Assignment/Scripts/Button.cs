using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    public GameObject cargo;
    public Transform cargoSpawn;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Button activated!");
        Instantiate(cargo, cargoSpawn.position, cargoSpawn.rotation);

    }


}
