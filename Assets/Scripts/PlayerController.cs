﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;

    public float verticalInput;

    public float speed = 25.0f;

    public float xRange = 15.0f;

    public float zRange = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // create boundaries for player
        if (transform.position.x < -xRange) {
            // if true keep x bound position
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) {
            // if true keep x bound position
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRange)
        {
            // if true keep z bound position
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }

        if (transform.position.z > zRange)
        {
            // if true keep z bound position
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }



        // get input from left and right arrow keys
        horizontalInput = Input.GetAxis("Horizontal");

        // Translate position on x-axis
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // get input from up and down arrow keys
        verticalInput = Input.GetAxis("Vertical");

        // Translate position on z-axis
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
