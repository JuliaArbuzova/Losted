using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
    }
    

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-5 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(5 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Walls")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(5 * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(-5 * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, -5 * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 5 * Time.deltaTime, 0);
            }
        }
        //if (collision.gameObject.tag == "Exit")
        //{
        //
        //}
    }
    
}