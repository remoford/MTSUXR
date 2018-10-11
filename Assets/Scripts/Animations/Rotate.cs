using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	
    public Button faster;
    public Button slower;
    float speed = 6;

    void Start()
    {
        Button btn1 = faster.GetComponent<Button>(); // user can control speed of rotation by air tapping buttons
        btn1.onClick.AddListener(Faster);

        Button btn2 = slower.GetComponent<Button>();
        btn2.onClick.AddListener(Slower);
    }

    void Faster()
    {
        speed += 1;
    }
    void Slower()
    {
        speed -= 1;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);

    }
}
