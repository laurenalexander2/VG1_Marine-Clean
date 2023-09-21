using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        // check if the collided object is the "garbage" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Garbage"))
        {
            // if layer = garabe, then get rid of it
            Destroy(collision.gameObject);
        }
    }

    
}
