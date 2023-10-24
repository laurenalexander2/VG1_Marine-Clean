using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DataManager", menuName = "Persistence")]
public class DataManager : ScriptableObject {
        public int highscore1;
        public int highscore2;
        public int highscore3;
        public int highscore4;

}
/*
    public static DataManager instance;
    //public int highscore ;
    public int highscore1;
    public int highscore2;
    public int highscore3;
    public int highscore4;
    public int currentLevel;
    //string scoreKey = "Highscore"
    //public int CurrentScore {get; set;};

    void Awake()
    {
        if (instance == null)
        {
            // Set this instance as the instance reference.
            instance = this;
        }
        else if(instance != this)
        {
            // If the instance reference has already been set, and this is not the
            // the instance reference, destroy this game object.
            Destroy(gameObject);
        }

        // Do not destroy this object, when we load a new scene.
        DontDestroyOnLoad(gameObject);
    }
*/


//dd}
