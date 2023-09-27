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
        
        public int pointValue;
        // Start is called before the first frame update
        void Start()
        {
             currentHp = startingHp;
        }

        // Update is called once per frame
        void Update()
        {
            if (currentHp <= 0) {

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
                currentHp = currentHp - velocityDifference*impactScalar;
          //  Debug.Log(currentHp); 
          // }
        }
        void OnCollisionStay2D(Collision2D other)
        {
            velocityDifference = other.relativeVelocity.magnitude;
            if (velocityDifference > scrapeSense)
            {
                currentHp = currentHp - velocityDifference * scrapeScalar * Time.deltaTime;
               // Debug.Log(currentHp);
            }
        }
    }
}