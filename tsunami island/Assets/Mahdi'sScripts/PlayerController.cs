using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    // Use this for initialization
    void Start()
    {
        //Sets the rb to the rigid body of the player
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Gets the x and z axis values and sets them to x and z
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Creates a new vector for movement
        Vector3 movement = new Vector3(x, 0f, z);

        //Adds a force to the game object to make it move
        rb.AddForce(movement * speed);


    }
}

