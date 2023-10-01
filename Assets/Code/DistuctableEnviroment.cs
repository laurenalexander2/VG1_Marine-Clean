using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace enviroment {
    public class DistuctableEnviroment : MonoBehaviour
    {


        //Variables
        public float startingHp;
        private float currentHp;
        private float velocityDifference;
        public int impactScalar;
        public float scrapeScalar;
        public float scrapeSense;
        public GameObject target;
        public bool aboveTwoThirds = true;
        public bool aboveOneThirds = true;
        public bool alive = true;
        //stateTracking



        public int pointValue;
        // Start is called before the first frame update
        void Start()
        {
             currentHp = startingHp;
        }

        // Update is called once per frame
        void Update()
        {
           

    


        }
         void OnCollisionEnter2D(Collision2D other){
            /* if (other.gameObject.GetComponent<SimpleMovement>())
             {*/
            velocityDifference = other.relativeVelocity.magnitude;
            if (velocityDifference > 0.05)
            {
                currentHp = currentHp - velocityDifference * impactScalar;
                
            }
            //deduct 1/3 point when at 2/3 health
            if (aboveTwoThirds && currentHp <= startingHp * (2 / 3))
            {
                aboveTwoThirds =    false;
                GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue / 3);
            }

            //deduct 1/3 points at 1/3 hp
            if ( aboveOneThirds && currentHp <= startingHp / 3)
            {
                aboveOneThirds = false;
                GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue / 3);
            }

            if ( alive && currentHp <= 0)
            {
                alive= false;
                GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue / 3);
                // target.GetComponent<ScoreSystem>().points = target.GetComponent<ScoreSystem>().points - pointValue;
                //ScoreSystem.AddPoint(pointValue);
               

                Destroy(gameObject);

            }

        }
        void OnCollisionStay2D(Collision2D other)
        {
            velocityDifference = other.relativeVelocity.magnitude;
            if (velocityDifference > scrapeSense)
            {
                currentHp = currentHp - velocityDifference * scrapeScalar * Time.deltaTime;
               // Debug.Log(currentHp);
            }
            //deduct 1/3 points when at 2/3 health
            if (aboveTwoThirds && currentHp <= startingHp * (2 / 3))
            {
                aboveTwoThirds = false;
                GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue / 3);
            }
            //deduct 1/3 points at 1/3 hp
            if (aboveOneThirds && currentHp <= startingHp / 3)
            {
                aboveOneThirds = false;
                GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue / 3);
            }

            if ( alive && currentHp <= 0)
            {
                    alive= false;
                GameObject.Find("Timer").GetComponent<ScoreSystem>().AddPoint(pointValue / 3);
                // target.GetComponent<ScoreSystem>().points = target.GetComponent<ScoreSystem>().points - pointValue;
                //ScoreSystem.AddPoint(pointValue);
                

                Destroy(gameObject);

            }

            
        }
    }
}