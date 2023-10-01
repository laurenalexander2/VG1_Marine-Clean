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
        public float fuelSpendSpeed;
        public float fuelRegen;
        public float fuelMax;

        //Methods
        void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            fuel = fuelMax;
        }

        //state tracker
        private float fuel;


        void Update()
        {
            //fuel regen
            if ( !Input.GetKey(KeyCode.Space) && fuel < fuelMax)
            {
                fuel = fuel + (fuelRegen * Time.deltaTime);
               // print(fuel);
            }
            if ( fuel > fuelMax ) {
                fuel = fuelMax;
            }

            //Move Player Left
            if (Input.GetKey(KeyCode.A))
            {
                _rigidbody2D.AddForce(Vector2.left * speed * Time.deltaTime);
                //horizontal thrust
                if (Input.GetKey(KeyCode.Space))
                {
                    if (fuel > 0)
                    {
                        fuel = fuel - (fuelSpendSpeed * Time.deltaTime);
                       // print(fuel);
                        _rigidbody2D.AddForce(Vector2.left * jetSpeed * Time.deltaTime, ForceMode2D.Impulse);
                        
                    }
                }

            }

            //Move Player Right
            if (Input.GetKey(KeyCode.D))
            {
                _rigidbody2D.AddForce(Vector2.right * speed * Time.deltaTime);
                //horizontal thrust
                if (Input.GetKey(KeyCode.Space))
                {
                    if (fuel > 0)
                    {
                        fuel = fuel -  (fuelSpendSpeed * Time.deltaTime);
                       // print(fuel);
                        _rigidbody2D.AddForce(Vector2.right * jetSpeed * Time.deltaTime, ForceMode2D.Impulse);
                    }
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

    }
}