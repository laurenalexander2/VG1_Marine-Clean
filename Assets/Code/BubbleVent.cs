using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleVent : MonoBehaviour
{
  
    //outlets
    Rigidbody2D _rigidBody;
    public GameObject bubblePrefab;

    //
    private float angle;
    private Vector2 slope;

    //state trackers
    public int intervals;
    private float timeElapsed;
    public bool isOn;
    private GameObject newBubble;
    private float totalTime;
    
    
    void Start()
    {
        angle = transform.localEulerAngles.z;
      if (isOn)
        {
            newBubble = Instantiate(bubblePrefab);
            newBubble.transform.position = transform.position;
            newBubble.transform.rotation = transform.rotation;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed = TimerCode.instance.timeElapsed;
        if( timeElapsed - totalTime > intervals )
        {

            if (isOn)
            {
                //destroy current bubble
                isOn = false;
                totalTime += timeElapsed;
                Destroy(newBubble);
            }
            else
            {
               isOn= true;
                totalTime += timeElapsed;
                newBubble = Instantiate(bubblePrefab);
                newBubble.transform.position = transform.position;
                newBubble.transform.rotation = transform.rotation;

            }


        }
       
        
        
    }
}
