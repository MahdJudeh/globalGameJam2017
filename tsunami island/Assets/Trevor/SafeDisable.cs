using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDisable : MonoBehaviour {
    
    private int breaks = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Safe")
        {
            if (breaks < 3)
            {
                breaks++;
                Disable(other);
            }
        }
    }

    IEnumerable Disable(Collider other)
    {
        other.enabled = false;
        yield return new WaitForSeconds(2);
        other.enabled = true;
    }
}
