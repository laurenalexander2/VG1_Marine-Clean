using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public int pointValue;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Garbage"))
        {
            //adding point
            //ScoreSystem.instance.AddPoint(pointValue);

            Destroy(collider.gameObject);
        }

    }

}