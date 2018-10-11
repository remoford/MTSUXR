using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    
    public Camera EarthView;
    public Camera SpaceView;
    
    
    
	// Update is called once per frame
	void Update ()
    {
        EarthView.enabled = true;
        SpaceView.enabled = false;

        if (Input.GetKey("space"))
        {

            EarthView.enabled = !EarthView.enabled;
            SpaceView.enabled = !SpaceView.enabled;

        }

        
          
	}
}
