using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour {
    public GameObject Wave;
    private int time;
    private int divider;
	// Use this for initialization
	void Start () {
        time = 0;
        divider = 1;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        {
            Instantiate(Wave, new Vector3(Random.Range(150.0f, 200.0f), 0, Random.Range(150.0f, 200.0f)), Quaternion.identity);
        }
       
    }
}
