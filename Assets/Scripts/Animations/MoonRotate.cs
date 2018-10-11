using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;


public class MoonRotate : MonoBehaviour
{

    // Ok, ive added a comment here to test out git woo!

    public Button faster;
    public Button slower;
    float speed = 6;

    public GameObject Source;
   
    // Use this for initialization
    void Start()
    {
        Button btn1 = faster.GetComponent<Button>();
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
        
        transform.RotateAround(Source.transform.position, Vector3.up, speed * Time.deltaTime);
            
    }
}

