using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    private Transform ptrans;  //player
    private float mouseH;
    private float x;

	// Use this for initialization
	void Start () {

        //finds player
		ptrans = GameObject.FindWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        //attaches camera
        transform.position = new Vector3(ptrans.position.x, ptrans.position.y + 2, ptrans.position.z - 2);
        //mouseH = Input.GetAxis("Mouse X");
        //x += mouseH;
        //transform.rotation = Quaternion.Euler(0, x, 0); 
    }
}
