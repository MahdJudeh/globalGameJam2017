using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDisable : MonoBehaviour {

    public float waveSpeed;
    
    private int breaks = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.position+=transform.right*waveSpeed;
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Safe")
        {
            if (breaks < 3)
            {
                Debug.Log(breaks);
                breaks++;
                StartCoroutine(Disable(other));
            }
        }
    }

    IEnumerator Disable(Collider other)
    {
        Debug.Log("Started Disable");
        other.enabled = false;
        yield return new WaitForSecondsRealtime(2);
        Debug.Log("Yeild works");
        other.enabled = true;
    }
}
