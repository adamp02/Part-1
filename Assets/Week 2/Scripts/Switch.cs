using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch: MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();   

        spriteRenderer.color = Color.green;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entered the trigger!");
        spriteRenderer.color = Color.red;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exited the trigger!");
        spriteRenderer.color = Color.green;
    }


}
