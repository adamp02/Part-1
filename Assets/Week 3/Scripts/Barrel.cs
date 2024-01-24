using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public CircleCollider2D collider;
    public GameObject barrelA;
    public GameObject barrelB;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("You knocked over a barrel!");
        collider.enabled = false;
        barrelA.SetActive(false);
        barrelB.SetActive(true);   
    }

}
