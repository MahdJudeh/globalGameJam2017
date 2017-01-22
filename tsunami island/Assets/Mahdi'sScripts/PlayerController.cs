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
    public static float maxSpeed = 5f;
    public float angle = 0f;
    public float speed;
    public Text wood;
    public Text rock;
    private bool grounded;
    private Animator anim;
    public float jump;

    public float newx, newz;
    // Use this for initialization
    void Start()
    {
        //Sets the rb to the rigid body of the player
        rb = gameObject.GetComponent<Rigidbody>();
        Rscore = 0;
        Wscore = 0;
        wood.text = "" + Wscore;
        //rock.text = "" + Rscore;
        grounded = true;
        anim = GetComponent<Animator>();
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
        Vector3 mov = new Vector3(x, 0f, z);

        //Adds a force to the game object to make it move
        //        if (rb.velocity.magnitude < maxSpeed)
        rb.AddForce(mov * speed);

        //rb.freezeRotation = true;

        //newx += x;
        //if (newx < -1) newx = -1;
        //else if (newx > 1) newx = 1;
        //newz += z;
        //if (newz < -1) newz = -1;
        //else if (newz > 1) newz = 1;

        if (x != 0 || z != 0)
        {
            mov = new Vector3(x, 0f, z);
            anim.SetTrigger("running_inPlace");
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(mov), speed * Time.deltaTime);
        }
        else
        {
            anim.SetTrigger("sad_idle");
        }
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

    }
    void OnCollisionEnter(Collision other)
    {
        Vector3 normal = new Vector3(0, 1, 0);
        if (other.contacts[0].normal == normal)
        {
            grounded = true;
        }
    }
    void OnCollisionExit(Collision other)
    {

        grounded = false;

    }
    void OnCollisionStay(Collision other)
    {
        Vector3 normal = new Vector3(0, 1, 0);
        if (other.contacts[0].normal == normal)
        {
            grounded = true;
        }
    }
}

