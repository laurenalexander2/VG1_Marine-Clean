using System.Collections;
using System.Collections.Generic;
using UnityEngine;


       
          
        
    

namespace PlayerTracking { 

public class CameraMovement : MonoBehaviour{
    public Transform Target;


    //config
   public Vector3 offset;
   public float smoothTime;

    //State Tracking 
   Vector3 currentVelocity;


     private void start()
    {
       

        transform.position = Target.position + offset;

    }

    private void FixedUpdate()
    {

        if (Target)
        {
            transform.position = Vector3.SmoothDamp(
             transform.position,
             Target.position + offset,
             ref currentVelocity,
             smoothTime
             );
        } else {
            Debug.Log("Player not found");
        }
        }
    }
}
