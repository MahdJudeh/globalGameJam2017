using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScript : MonoBehaviour {

    public Text text;
	
	void OnTriggerStay()
    {
        
        text.enabled=true;
         
	}

    void OnTriggerExit()
    {
        //text.enabled = false;
    }
}
