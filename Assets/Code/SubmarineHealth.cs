using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float currentHealth;
    public HealthBarScript healthBar;
    private int damage;
    private float velocityDifference;
    public int impactScalar;
    public float scrapeScalar;
    public float scrapeSense;
    public GameObject target;
    public int pointValue;
    public GameObject timer;
    private TimerCode timerScript;
    public GameObject endScreen;

            void Start()
            {
                 currentHealth = maxHealth;
                 healthBar.SetMaxHealth(maxHealth);
                 healthBar.SetHealth(currentHealth);
                 timerScript = timer.GetComponent<TimerCode>();

            }

            // Update is called once per frame
            void Update()
            {
                if (currentHealth <= 0) {

                    GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue);
                   // target.GetComponent<ScoreSystem>().points = target.GetComponent<ScoreSystem>().points - pointValue;
                    //ScoreSystem.AddPoint(pointValue);
                    print(target.GetComponent<ScoreSystem>().points);


                    Destroy(gameObject);

                }
            }
            void OnCollisionEnter2D(Collision2D other){
                /* if (other.gameObject.GetComponent<SimpleMovement>())
                 {*/
                velocityDifference = other.relativeVelocity.magnitude;
                    currentHealth = currentHealth - velocityDifference*impactScalar;
                    healthBar.SetHealth(currentHealth);

                    if(currentHealth <= 0){
                        endScreen.SetActive(true);
                        timerScript.timerOn = false;
                    }
              //  Debug.Log(currentHp);
              // }
            }
            void OnCollisionStay2D(Collision2D other)
            {
                velocityDifference = other.relativeVelocity.magnitude;
                if (velocityDifference > scrapeSense)
                {
                    currentHealth = currentHealth - velocityDifference * scrapeScalar * Time.deltaTime;
                   healthBar.SetHealth(currentHealth);
                   if(currentHealth <= 0){
                   endScreen.SetActive(true);
                   timerScript.timerOn = false;
                                       }

                   // Debug.Log(currentHp);
                }
            }
        }

