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
    private SpriteRenderer sprite;
    public int ramp;
    private float bubbleSpeed;


    //stateTracker
    public int rampTracker;

    // Start is called before the first frame update
    void Start()
    {
        bubbleSpeed = Random.Range(2, 9) / 10f;
        sprite = GetComponent<SpriteRenderer>();
        StartCoroutine("Bubbling");
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
        if (TimerCode.instance.timeElapsedOn)
        {
            _rigidBody = collider.GetComponent<Rigidbody2D>();
            _rigidBody.AddForce(slope * power * Time.deltaTime);
        }
        
    }
    IEnumerator Bubbling()
    {
        if (TimerCode.instance.timeElapsedOn) { 
        bubbleSpeed = Random.Range(3, 8) / 10f;
        yield return new WaitForSeconds(bubbleSpeed);
        if (sprite.flipX)
        {
            sprite.flipX = false;
        } else
        {
            sprite.flipX = true;
        }
            StartCoroutine("Bubbling");
        } else
        {
            yield return new WaitForSeconds(1);
        StartCoroutine("Bubbling");
        }

        
    }
     
    }

