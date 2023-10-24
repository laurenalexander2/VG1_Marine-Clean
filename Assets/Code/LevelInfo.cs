using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelInfo : MonoBehaviour
{
public float Highscore;
public float levelNumber;
public GameObject Star1;
public GameObject Star2;
public GameObject Star3;
public bool completed = false;
//public string nextSceneName;

[SerializeField]
public DataManager data;
    // Start is called before the first frame updated
    void Start()
    {
    //GameObject StarLevels = GameObject.Find(parentObjectName);

        //Star1.SetActive(false);// = false;
        //Star2.SetActive(false);// = false;
        //Star3.SetActive(false);// = false;
        if(levelNumber == 1){
                Highscore = data.highscore1;
                completed = true;
            }
            if(levelNumber == 2){
                Highscore = data.highscore2;
                completed = true;
            }
            if(levelNumber == 3){
               Highscore = data.highscore3;
               completed = true;
            }
            if(levelNumber == 4){
                Highscore = data.highscore4;
                completed = true;
            }
        if (Highscore >= 1) {
            SpriteRenderer s1 = Star1.GetComponent<SpriteRenderer>();
            s1.enabled = true;

            }// = true;
        if (Highscore >= 2) {

        SpriteRenderer s2 = Star2.GetComponent<SpriteRenderer>();
        s2.enabled = true;

        }// = true;
        if (Highscore >= 3) {
        SpriteRenderer s3 = Star3.GetComponent<SpriteRenderer>();
        s3.enabled = true;

        }// = true;
    }
}
