using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;
public class AirTap : MonoBehaviour {

    // example code from Lynda.com for using gaze and gesture in Unity

    public Material MaterialInGaze;
    private Material _oldMaterial;
    private GameObject _objectInFocus;

    // Use this for initialization
    void Start()
    {
        GestureRecognizer gestureRecognizer = new GestureRecognizer();
        gestureRecognizer.SetRecognizableGestures(GestureSettings.Tap);
        gestureRecognizer.TappedEvent += GestureRecognizer_TappedEvent;
        gestureRecognizer.StartCapturingGestures();
    }

    private void GestureRecognizer_TappedEvent(InteractionSourceKind source, int tapCount, Ray headRay)
    {
        if (_objectInFocus == null)
        {
            return;
        }
        _objectInFocus.SendMessage("DoThis"); // the message can call a function. Maybe I can use this to switch scenes when button is pressed
    }
	
    // Update is called once per frame
	void Update ()
    {
        var ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit raycastInfo;

		if (Physics.Raycast(ray, out raycastInfo))
        {
            var hitObject = raycastInfo.transform.gameObject;
            if (hitObject == _objectInFocus)
            {
                return;
            }
            var renderer = hitObject.GetComponent<Renderer>();
            if (renderer == null)
            {
                return;
            }
            _oldMaterial = renderer.material;
            renderer.material = MaterialInGaze;
            _objectInFocus = hitObject;

        }
        else
        {
            if (_objectInFocus == null)
            {
                return;
            }
            var renderer = _objectInFocus.GetComponent<Renderer>();
            renderer.material = _oldMaterial;
            _objectInFocus = null;
        }

	}
}
