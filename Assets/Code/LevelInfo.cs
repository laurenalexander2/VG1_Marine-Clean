using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelInfo : MonoBehaviour
{
public float Highscore;
public float levelNumber;
public Image Star1;
public Image Star2;
public Image Star3;

[SerializeField]
public DataManager data;
    // Start is called before the first frame update
    void Start()
    {
        Star1.enabled = false;
        Star2.enabled = false;
        Star3.enabled = false;

        if(levelNumber == 1){
                Highscore = data.highscore1;
            }
            if(levelNumber == 2){
                Highscore = data.highscore2;
            }
            if(levelNumber == 3){
               Highscore = data.highscore3;
            }
            if(levelNumber == 4){
                Highscore = data.highscore4;
            }
        if (Highscore >= 1) Star1.enabled = true;
        if (Highscore >= 2) Star2.enabled = true;
        if (Highscore >= 3) Star3.enabled = true;
    }
}
