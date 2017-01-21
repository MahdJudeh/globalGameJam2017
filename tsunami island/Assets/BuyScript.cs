using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScript : MonoBehaviour {

    public Text text;
	
	void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        if (other.tag == "Player")
        {
            Debug.Log("entered");
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
        }
    }
}
