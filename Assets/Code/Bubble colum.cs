using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bubblecolum : MonoBehaviour
{
    //outlets
    public float power;
    Rigidbody2D _rigidBody;
    private Collider2D enteredObject;
    private float angle;
    private Vector2 slope;

    public int ramp;


    //stateTracker
    public int rampTracker;

    // Start is called before the first frame update
    void Start()
    {
       angle = transform.localEulerAngles.z;

        //acounts for the capsule being perpindicular to the x-axis
        angle = angle + 90f;
        
       slope = new Vector2(Mathf.Cos(angle* Mathf.Deg2Rad), Mathf.Sin(angle* Mathf.Deg2Rad));
       // Debug.Log(slope);
      
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
         _rigidBody = collider.GetComponent<Rigidbody2D>();
       //Debug.Log("enteredd collum");
        rampTracker = ramp;
        enteredObject = collider;
    }
    void OnTriggerStay2D(Collider2D collider)
    {

        /*  if (rampTracker > 0) { }
          {
              _rigidBody.AddForce((slope * power) / rampTracker * Time.deltaTime);
              Debug.Log(rampTracker);
             --rampTracker;

         }*/
        // Debug.Log("adding force");
        if (collider == enteredObject)
        {
            _rigidBody.AddForce(slope * power * Time.deltaTime);
        }
        
    }
   
    }

