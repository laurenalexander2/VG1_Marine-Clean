using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public int pointValue;
    public int scrapValue;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("player Character"))
        {
            //adding point
            //ScoreSystem.instance.AddPoint(pointValue);
            GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue);
            GameObject.Find("Timer").GetComponent<ScrapSystem>().addScrap(scrapValue);
            Destroy(gameObject);
        }

    }

}