using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace movement
{
    public class SimpleMovement : MonoBehaviour
    {
        //Outlet
        Rigidbody2D _rigidbody2D;
       


        //Methods
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }


        void Update()
        {
            //Move Player Left
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                _rigidbody2D.AddForce(Vector2.left * 5f * Time.deltaTime, ForceMode2D.Impulse);
            }

            //Move Player Right
            if (Input.GetKey(KeyCode.RightArrow))
            {
                _rigidbody2D.AddForce(Vector2.right * 5f * Time.deltaTime, ForceMode2D.Impulse);
            }

            //Move Player Up
            if (Input.GetKey(KeyCode.UpArrow))
            {
                _rigidbody2D.AddForce(Vector2.up * 5f * Time.deltaTime, ForceMode2D.Impulse);
            }

            //Move Player Down
            if (Input.GetKey(KeyCode.DownArrow))
            {

                _rigidbody2D.AddForce(Vector2.down * 5f * Time.deltaTime, ForceMode2D.Impulse);
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