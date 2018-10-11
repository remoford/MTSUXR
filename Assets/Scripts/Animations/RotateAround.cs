using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float speed = 6;

    

	// Update is called once per frame
	void Update ()
    {
        
        transform.RotateAround(Vector3.zero,Vector3.up, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            speed += 1; // increases speed when right arrow is pressed
            
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // could probably also use GetButtonDown - user presses a virtual button
        {
            speed -= 1; // increases speed when left arrow is pressed
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed = 6; // sets speed to default position
        }
    }
}
