using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    //Outlet
    Rigidbody2D _rigidbody2D;

    //Config
    public float aceleration;

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
            _rigidbody2D.AddForce(Vector2.left * aceleration * Time.deltaTime, ForceMode2D.Impulse);
        }

        //Move Player Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody2D.AddForce(Vector2.right * aceleration * Time.deltaTime, ForceMode2D.Impulse);
        }

        //Move Player Up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody2D.AddForce(Vector2.up * aceleration * Time.deltaTime, ForceMode2D.Impulse);
        }

        //Move Player Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody2D.AddForce(Vector2.down * aceleration * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
