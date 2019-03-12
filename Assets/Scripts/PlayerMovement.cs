using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Rigidbody rb;

    public float forwardForce = 10f;
    public float sideforce = 400f;
    public float jump = 200f;
    public float doubleJump = 400f;
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.velocity = new Vector3(0, 0, 30);

        Debug.Log(rb.velocity);
        
        if ( Input.GetKey("a"))
        {
            ///Debug.Log("d pressed");
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            ///Debug.Log("d pressed");
            rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }



 
    }

    
}
