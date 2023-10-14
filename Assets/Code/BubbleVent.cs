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
    private int timeElapsed;
    public bool isOn;
    private GameObject newBubble;
    
    
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
        if(timeElapsed > intervals)
        {

            if (isOn)
            {
                //destroy current bubble
                isOn = false;
                timeElapsed = 0;
                Destroy(newBubble);
            }
            else
            {
               isOn= true;
                timeElapsed = 0;
                newBubble = Instantiate(bubblePrefab);
                newBubble.transform.position = transform.position;
                newBubble.transform.rotation = transform.rotation;

            }


        }
        else {
            ++timeElapsed;
            }
        
        
    }
}
