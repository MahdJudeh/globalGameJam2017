using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public static int Rscore;
    public static int Wscore;
    public float speed;
    public Text wood;
    public Text rock;
    // Use this for initialization
    void Start()
    {
        //Sets the rb to the rigid body of the player
        rb = gameObject.GetComponent<Rigidbody>();
        Rscore = 0;
        Wscore = 0;
        wood.text = "" + Wscore;
        rock.text = "" + Rscore;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded == true)
        {

            {
                rb.AddForce(0f, jump, 0f);
            }
        }
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
        rb.freezeRotation = true;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wood")
        {
            Destroy(other.gameObject);
            Wscore += 1;
            wood.text = "" + Wscore;
        }

        if (other.tag == "Rock")
        {
            Destroy(other.gameObject);
            Rscore += 1;
            rock.text = "" + Rscore;
        }
        if (other.tag == "Floor")
        {
            grounded = true;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Floor")
        {
            grounded = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Floor")
        {
            grounded = false;
        }
    }
}

