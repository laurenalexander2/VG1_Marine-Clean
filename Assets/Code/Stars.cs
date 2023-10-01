using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
 public ScoreSystem counter;
 public Image Star1;
 public Image Star2;
 public Image Star3;
 public int star = 0;
 public GameObject Timer;
 public TimerCode time;
    
    // Start is called before the first frame update
    void Start()
    {
       
    Star1.enabled = false;
    Star2.enabled = false;
    Star3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    if(time.timerOn == false) {
          float targetScore = Timer.GetComponent<ScoreSystem>().startPoints;
            //print(targetScore);
           float aceivedScore = Timer.GetComponent<ScoreSystem>().points;
           // print(aceivedScore);
            float scorePercentage = aceivedScore/targetScore;
           // print(scorePercentage);
                if (scorePercentage >= .9 ){
                    star = 3;
                  StarDisplay(star);
                } else if(scorePercentage >= .75) {
                    star = 2;
                    StarDisplay(star);
                }else if(scorePercentage >= .50 ){
                    star = 1;
                    StarDisplay(star);
                }else{
                    star = 0;
                    StarDisplay(star);

                }
    }
    }
    void StarDisplay(int starscore) {
            if(starscore == 3){
                Star1.enabled = true;
                Star2.enabled = true;
                Star3.enabled = true;
            }else if(starscore == 2){
                Star1.enabled = true;
                Star2.enabled = true;
                Star3.enabled = false;
            }else if(starscore == 1){
            Star1.enabled = true;
            Star2.enabled = false;
            Star3.enabled = false;
            }else {
            Star1.enabled = false;
            Star2.enabled = false;
            Star3.enabled = false;
            }
    }
}
