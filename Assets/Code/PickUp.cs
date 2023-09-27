using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public int pointValue;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // check if the collided object is the "garbage" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Garbage"))
        {
            // if layer = garabe, then get rid of it
            Destroy(collision.gameObject);
            
        }
        //put the following inside the code for picking up things that give points
        //calling the following will add 1 point to the score
        //ScoreSystem.instance.AddPoint();

    }

//void Activate(); //this is to activate the scoring system when we pick up something
}
