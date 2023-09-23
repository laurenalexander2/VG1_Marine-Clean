using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace enviroment {
    public class DistuctableEnviroment : MonoBehaviour
    {


        //Variables
        public float startingHp;
        private float currentHp;
        private float incomingVelocity;
        public int damageScalar;

        // Start is called before the first frame update
        void Start()
        {
             currentHp = startingHp;
        }

        // Update is called once per frame
        void Update()
        {
            if (currentHp <= 0) {
                Destroy(gameObject);
            }
        }
         void OnCollisionEnter2D(Collision2D other){
           /* if (other.gameObject.GetComponent<SimpleMovement>())
            {*/
                incomingVelocity = other.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude;
                currentHp = currentHp - incomingVelocity*damageScalar;
            Debug.Log(currentHp); 
          // }
        }
    }
}