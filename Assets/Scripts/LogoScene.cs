using UnityEngine;
using System.Collections;

public class LogoScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("GoToStart",6.0f);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void GoToStart()
    {
        Application.LoadLevel("Start_Scene");
    }
}
