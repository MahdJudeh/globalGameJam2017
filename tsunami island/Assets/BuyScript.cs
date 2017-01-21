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

//Update is being used to check to see if the player is pressing B at any point in time. If the player is pressing B and the ammount of wood
// they have is greater than 5, then the player can buy the spot and the houses cost is incremented by a multiple of its cost. New houses
// are then bought for a higher ammount and spawned ontop of the first house.
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
                    Wood.text = "" + (Int32.Parse(Wood.text) - woodCost);
                    woodMultiplier++;
                    woodCost *= 1 + woodMultiplier;
                }
                else
                {
                    Debug.Log(Int32.Parse(Wood.text));
                    Instantiate(house1, new Vector3(-2.0f, 3.0f, -2.0f), Quaternion.identity);
                    Wood.text = "" + (Int32.Parse(Wood.text) - woodCost);
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
