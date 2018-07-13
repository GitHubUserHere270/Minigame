using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickMovement : MonoBehaviour {

    // Use this for initialization
    public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.position += new Vector3(0, speed*Time.deltaTime, 0);
		
	}



}
