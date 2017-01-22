using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    public GameObject screen;
    
    public bool safe;

	void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Safe")
        //{
        //    safe = true;
        //}
        //else
        //{
        //    safe = false;
        //}

        if (other.tag=="Water")
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            screen.SetActive(true);
        }
        else if (other.tag == "Tsunami")
        {
            if (!safe)
            {
                gameObject.transform.parent.gameObject.SetActive(false);
                screen.SetActive(true);
            }
        }
        
    }
    void OnTriggerStay(Collider other){
        if (other.tag == "Safe")
            safe = true;
    }
    void OnTriggerExit(Collider other)
    {
        safe = false;
    }
}
