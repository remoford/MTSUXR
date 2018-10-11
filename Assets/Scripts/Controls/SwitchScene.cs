using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {

    public Button Next;
    public Button Previous;
    public string NextScene;
    public string PrevScene;


    // Use this for initialization
    void Start ()
    {
    Button btn = Next.GetComponent<Button>();
    btn.onClick.AddListener(Forward);

    Button btn2 = Previous.GetComponent<Button>();
    btn2.onClick.AddListener(Backward);
    }
	
	void Forward()
    {
    SceneManager.LoadScene(NextScene);
    }
    void Backward()
    {
    SceneManager.LoadScene(PrevScene);
    }
}
