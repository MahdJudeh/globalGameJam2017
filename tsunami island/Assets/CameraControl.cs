using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private Transform ptrans;

	// Use this for initialization
	void Start () {
		ptrans = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = ptrans.position;
        transform.position.y + 10;
        transform.position.z - 10;

    }
}
