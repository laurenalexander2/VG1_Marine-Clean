using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkBehavior : MonoBehaviour
{
    public float timeElapsed;
    public float turf;
    public bool isPatrolling;
    private float xstartPosittion;
    private float ystartPosittion;
    public float xSpeed;
    public float ySpeed;
    private float xpos;
    private float ypos;
    // Start is called before the first frame update
    void Start()
    {
        xstartPosittion = gameObject.transform.position.x;
        ystartPosittion = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPatrolling)
        {
            timeElapsed += Time.deltaTime;
            if(xSpeed > 0)
            {
                 xpos = Mathf.Sin(timeElapsed / xSpeed) * Mathf.Deg2Rad * turf;
            } else {
                xpos = 0;
            }
            if (ySpeed > 0) {
                 ypos = Mathf.Cos(timeElapsed / ySpeed) * Mathf.Deg2Rad * turf;
            } else
            {
                ypos = 0;
            }
            
            transform.position = new Vector2(xpos + xstartPosittion, ypos + ystartPosittion);
        }
    }
        
        
   }

