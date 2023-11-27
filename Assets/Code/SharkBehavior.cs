using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkBehavior : MonoBehaviour
{
    public float timeElapsed;
    public float turf;
    public bool onoff;
    private float xstartPosittion;
    private float ystartPosittion;
    // Start is called before the first frame update
    void Start()
    {
        xstartPosittion = gameObject.transform.position.x;
        ystartPosittion = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (onoff)
        {
            timeElapsed += Time.deltaTime;
            float xpos = Mathf.Sin(timeElapsed) * Mathf.Deg2Rad * turf;
            float ypos = Mathf.Cos(timeElapsed) * Mathf.Deg2Rad * turf;
            transform.position = new Vector2(xpos + xstartPosittion, ypos + ystartPosittion);
        }
    }
        
        
   }

