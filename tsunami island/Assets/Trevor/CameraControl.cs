using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private Transform ptrans;  //player

	// Use this for initialization
	void Start () {

        //finds player
		ptrans = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        //attaches camera
        transform.position = new Vector3(ptrans.position.x, ptrans.position.y + 1, ptrans.position.z - 1);

    }
}
