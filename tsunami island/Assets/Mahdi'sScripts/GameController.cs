using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject Moon;
    public GameObject Sun;
    public GameObject Ocean;
    public Text dayText;
    private int day;
    private int time;
    private float rotation = .003f;

	// Use this for initialization
	void Start () {
        time = 0;
        day = 0;
        Moon.GetComponent<Light>().enabled = false;
        Sun.transform.position = new Vector3(50f, 0f, 0f);
        Sun.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
        dayText.text = dayText.text + " " + day;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(time < 11400)
        {
            Ocean.transform.localScale += new Vector3(0f, 0.001f, 0f);
            Sun.transform.Rotate(rotation, 0f, 0f);
            time += 2;
            if(time == 11400)
            {
                Sun.GetComponent<Light>().enabled = false;
                Moon.GetComponent<Light>().enabled = true;
                Sun.transform.position = new Vector3(50f, 0f, 0f);
                Sun.transform.rotation = new Quaternion(0f, -90f, 0f, 0f);
            }
        }
        else if(time < 22800)
        {
            Ocean.transform.localScale -= new Vector3(0f, 0.001f, 0f);
            Moon.transform.Rotate(rotation, 0f, 0f);
            time += 2;
            if(time == 22800)
            {
                Moon.GetComponent<Light>().enabled = false;
            }
        }
	}
}
