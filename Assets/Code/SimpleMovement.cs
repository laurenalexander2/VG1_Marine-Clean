using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace movement
{
    public class SimpleMovement : MonoBehaviour
    {
        //Outlet
        Rigidbody2D _rigidbody2D;
        public float jetSpeed;
        public float speed;

        //Methods
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }


        void Update()
        {
            //Move Player Left
            if (Input.GetKey(KeyCode.A))
            {
                _rigidbody2D.AddForce(Vector2.left * speed * Time.deltaTime);
                //horizontal thrust
                if (Input.GetKey(KeyCode.Space))
                {
                    _rigidbody2D.AddForce(Vector2.left * jetSpeed * Time.deltaTime, ForceMode2D.Impulse);
                }

            }

            //Move Player Right
            if (Input.GetKey(KeyCode.D))
            {
                _rigidbody2D.AddForce(Vector2.right * speed * Time.deltaTime);
                //horizontal thrust
                if (Input.GetKey(KeyCode.Space))
                {
                    _rigidbody2D.AddForce(Vector2.right * jetSpeed * Time.deltaTime, ForceMode2D.Impulse);
                }
            }

            //Move Player Up
            if (Input.GetKey(KeyCode.W))
            {
                _rigidbody2D.AddForce(Vector2.up * speed * Time.deltaTime);
            }

            //Move Player Down
            if (Input.GetKey(KeyCode.S))
            {
                _rigidbody2D.AddForce(Vector2.down * speed * Time.deltaTime);
            }

           
          


           

        }





        void OnCollisionEnter(Collision collision)
        {
            // check if the collided object is the "garbage" layer
            if (collision.gameObject.layer == LayerMask.NameToLayer("Garbage"))
            {
                // if tag = garabe, then get rid of it
                Destroy(collision.gameObject);
            }
        }


    }
}