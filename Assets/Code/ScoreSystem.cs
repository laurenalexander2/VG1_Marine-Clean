using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;
    public int points;
    public int startPoints;
    public ProgressBar progressBar;

    public void Activate() {
        instance = this;
    }
    public void AddPoint(int pv) {
            points = points + pv;
       // Debug.Log(points);
        }
    // Start is called before the first frame update
    void Start()
    {   
        points  = 0;
        var manditoryObjectives = GameObject.FindGameObjectsWithTag("ManObj");
        var objCount = manditoryObjectives.Length;
        foreach ( var obj in manditoryObjectives ) {
         int mPoints =  obj.GetComponent<PickUp>().pointValue;
            startPoints = startPoints + mPoints;
            
        }
       // print(startPoints);
    }
    void Update() {
        if (progressBar) {
            float progress = (float)points / startPoints;
            progressBar.SetProgress(progress);
        }
    }
    // Update is called once per frame
}
