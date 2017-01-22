using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {
    public GameObject Wave;
    private int time;
    private int divider;

	// Use this for initialization
	void Start () {
        time = 2;
        divider = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        int rand = Random.Range(1, 5);
        if ((time) % (((5000 / divider))) == 0)
        {
            if (rand == 1)
            {
                Instantiate(Wave, new Vector3(Random.Range(150.0f, 200.0f), 0, 0), Quaternion.Euler(0, 180, 0));
            }
            else if (rand == 2)
            {
                Instantiate(Wave, new Vector3(0, 0, Random.Range(150.0f, 200.0f)), Quaternion.Euler(0, 90, 0));
            }
            else if (rand == 3)
            {
                Instantiate(Wave, new Vector3(Random.Range(-150.0f, -200.0f), 0, 0), Quaternion.Euler(0, 0, 0));
            }
            else if (rand == 4)
            {
                Instantiate(Wave, new Vector3(0, 0, Random.Range(-150.0f, -200.0f)), Quaternion.Euler(0, -90, 0));
            }
        }
        time += 2;
       
    }
}
