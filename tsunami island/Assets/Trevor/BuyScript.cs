using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;


public class BuyScript : MonoBehaviour {

    public Text text;
    public Text Rock;
    public Text Wood;
    public GameObject house1;
    public GameObject house2;
    public GameObject house3;

    private int woodMultiplier;
    private int rockMultiplier;
    private int woodCost;
    private int rockCost;
    private bool inTrigger;
	
    void Start()
    {
        rockCost = 7;
        woodCost = 5;
        inTrigger = false;
        woodMultiplier = 0;
        rockMultiplier = 0;
    }

    void Update()
    {
        Debug.Log(Int32.Parse(Wood.text));
        if (Int32.Parse(Wood.text) >= woodCost)
        {
            Debug.Log(Int32.Parse(Wood.text));
            if (Input.GetKeyDown("b"))
            {
                if (woodCost > 5)
                {
                    Debug.Log(Int32.Parse(Wood.text));
                    Instantiate(house1, new Vector3(-2.0f, 3.0f+ (.8f*woodMultiplier), -2.0f), Quaternion.identity);
                    PlayerController.Wscore = (PlayerController.Wscore - woodCost);
                    Wood.text = "" + PlayerController.Wscore;
                    woodMultiplier++;
                    woodCost *= 1 + woodMultiplier;
                }
                else
                {
                    Debug.Log(Int32.Parse(Wood.text));
                    Instantiate(house1, new Vector3(-2.0f, 3.0f, -2.0f), Quaternion.identity);
                    PlayerController.Wscore = (PlayerController.Wscore - woodCost);
                    Wood.text = "" + PlayerController.Wscore;
                    woodMultiplier++;
                    woodCost *= 1 + woodMultiplier;
                }
            }
        }
    }


	void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        if (other.tag == "Player")
        {
            Debug.Log("entered");
            inTrigger = true;
            text.enabled = true;
            Debug.Log("Should Have printed");
        }

    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("exited");
        if (other.tag == "Player")
        {
            text.enabled = false;
            inTrigger = false;
        }
    }
}
