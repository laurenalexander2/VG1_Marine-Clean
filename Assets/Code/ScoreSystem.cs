using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;
    public int points = 0;
    private int startPoints;

    public void Activate() {
        instance = this;
    }
    public void AddPoint(int pv) {
            points = points + pv;
        }
    // Start is called before the first frame update
    void Start()
    {   
        var manditoryObjectives = GameObject.FindGameObjectsWithTag("ManObj");
        var objCount = manditoryObjectives.Length;
        foreach ( var obj in manditoryObjectives ) {
         int points =  obj.GetComponent<PickUp>().pointValue;
            startPoints = startPoints + points;
            
        }
        print(startPoints);
    }
    void Update() {
    }
    // Update is called once per frame
}
