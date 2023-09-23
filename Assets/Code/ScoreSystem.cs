using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;
    public int points = 0;
    public void Activate() {
        instance = this;
    }
    public void AddPoint() {
            points = points + 1;
        }
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update() {
    }
    // Update is called once per frame
}
