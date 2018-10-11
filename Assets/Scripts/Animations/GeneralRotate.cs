using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

// this program causes an object to rotate around another (source)
public class GeneralRotate : MonoBehaviour
{

    public Button faster;
    public Button slower;
    float speed = 6;

    public GameObject Source; // the source the object should rotate around

    
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

    void Update()
    {

        transform.RotateAround(Source.transform.position, Vector3.up, speed * Time.deltaTime); // revolves around the source

    }
}


