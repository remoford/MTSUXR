using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMotion : MonoBehaviour {

    public GameObject Plane;

    float scalar = 1;

    float rate = 24; // number of hours for Earth to make one full turn (therefore the time for sun to go "around" Earth)

	// Update is called once per frame
	void Update ()
    {
        //transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
	}
}
