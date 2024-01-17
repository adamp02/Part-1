using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject missilePrefab;
    public Transform spawnPoint;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Missile launched!");
        Instantiate(missilePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
